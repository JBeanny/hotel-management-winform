using HotelManagement.Bridge;
using HotelManagement.Factory.Search;

namespace HotelManagement
{
    public partial class GuestCheckInCheckOutForm : Form
    {
        private IStrategy<Room> RoomStrategy = new RoomStrategy();
        private IStrategy<Reservation> ReservationStrategy = new ReservationStrategy();
        private IStrategy<Guest> GuestStrategy = new GuestStrategy();

        private Reservation searchedReservation = new Reservation();

        private SearchFactory factory;

        private ISearch searchMethod;

        public GuestCheckInCheckOutForm(List<Reservation> reservations)
        {
            InitializeComponent();
            detailPanel.Visible = false;
            factory = new SearchFactory(reservations);
            searchMethod = factory.CreateSearch(SearchFactory.SearchType.Reservation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.status.Text == "CHECK-IN")
            {
                this.status.Text = "CHECK-OUT";
            }
            else
            {
                this.status.Text = "CHECK-IN";
            }
        }

        // handle search action
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchedReservation = searchMethod.Search(searchTextBox.Text);
                getReservationInfo();
            }
        }

        // To get reservation info and fill into the form
        private void getReservationInfo()
        {
            reservationId.Text = searchedReservation.Id;

            // fetch guest by id
            Guest guest = GuestStrategy.ReadById(searchedReservation.GuestId);
            guestName.Text = guest.Name;
            guestPhone.Text = guest.Contact;
            guestNationalId.Text = guest.Id;

            // fetch room by id
            Room room = RoomStrategy.ReadById(searchedReservation.RoomId.ToString());
            roomName.Text = room.Name;
            chargeFee.Text = room.Charge_Fee.ToString();

            // calculate total price
            int totalDayResereved = (searchedReservation.EndDate - searchedReservation.StartDate).Days;
            double totalPrice = room.Charge_Fee * totalDayResereved;
            payment.Text = totalPrice.ToString();


            detailPanel.Visible = true;
        }


        // handle switch search type
        private void switchSearchType(object sender, MouseEventArgs e)
        {
            if(searchMethod is ReservationIdSearch) 
            {
                searchMethod = factory.CreateSearch(SearchFactory.SearchType.Guest);
                label1.Text = "Guest Id";
            }else {
                searchMethod = factory.CreateSearch(SearchFactory.SearchType.Reservation);
                label1.Text = "Reservation Id";
            }
        }
    }
}
