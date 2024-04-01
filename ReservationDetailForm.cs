using System.Net.Http.Headers;

namespace HotelManagement
{
    public partial class ReservationDetailForm : Form
    {
        private Room room = new Room();
        private Guest guest = new Guest();
        private Reservation reservation = new Reservation();
        private double totalPrice = 0.0;

        public ReservationDetailForm(Room room, Guest guest,Reservation reservation)
        {
            InitializeComponent();
            this.room = room;
            this.guest = guest;
            this.reservation = reservation;

            int totalDayResereved = (reservation.EndDate - reservation.StartDate).Days;
            totalPrice = room.Charge_Fee * totalDayResereved;
        }

        private void InitialLoad(object sender, EventArgs e)
        {
            if (this.room != null && this.guest != null)
            {
                reservationIdLabel.Text = reservation.Id;
                roomName.Text = room.Name;
                chargeFee.Text = room.Charge_Fee.ToString();

                payment.Text = totalPrice.ToString();
                
                guestName.Text = guest.Name;
                guestPhone.Text = guest.Contact;
                guestNationalId.Text = guest.Id;
                guestSex.Text = guest.Gender;
            }
        }
    }
}
