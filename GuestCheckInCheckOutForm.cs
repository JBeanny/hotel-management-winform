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

        private string reservationStatus = "0";

        private string alertMessage = "You have checked in. Have a nice rest 😊";

        public GuestCheckInCheckOutForm(List<Reservation> reservations)
        {
            InitializeComponent();
            detailPanel.Visible = false;
            factory = new SearchFactory(reservations);
            searchMethod = factory.CreateSearch(SearchFactory.SearchType.Reservation);
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchedReservation.CheckIn == "2")
                {
                    this.Close();
                    return;
                }

                searchedReservation.CheckIn = reservationStatus;
                ReservationStrategy.Update(searchedReservation.Id, searchedReservation);
                this.Close();

                MessageBox.Show(alertMessage, "Reservation Alert", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Failed to check in", "Reservation Alert", MessageBoxButtons.OK);
            }
        }

        // handle search action
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchedReservation = searchMethod.Search(searchTextBox.Text);
                getReservationInfo();

                if (searchedReservation.CheckIn == "0")
                {
                    this.status.Text = "Not Yet";
                    button1.Text = "Check In";
                    reservationStatus = "1";
                }
                else if (searchedReservation.CheckIn == "1")
                {
                    this.status.Text = "CHECK-IN";
                    button1.Text = "Check Out";
                    reservationStatus = "2";
                    alertMessage = "You have checked out. Be safe and visit us next time ❤";
                }
                else
                {
                    this.status.Text = "CHECK-OUT";
                    button1.Text = "Close";
                }
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
            guestSex.Text = guest.Gender;
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
            if (searchMethod is ReservationIdSearch)
            {
                searchMethod = factory.CreateSearch(SearchFactory.SearchType.Guest);
                label1.Text = "Guest Id";
            }
            else
            {
                searchMethod = factory.CreateSearch(SearchFactory.SearchType.Reservation);
                label1.Text = "Reservation Id";
            }
        }
    }
}
