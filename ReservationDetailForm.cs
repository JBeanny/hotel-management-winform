namespace HotelManagement
{
    public partial class ReservationDetailForm : Form
    {
        private Room room = new Room();
        private Guest guest = new Guest();

        public ReservationDetailForm(Room room, Guest guest)
        {
            InitializeComponent();
            this.room = room;
            this.guest = guest;
            roomName.Text = room.Name;
            chargeFee.Text = room.Charge_Fee.ToString();
            guestName.Text = guest.Name;
            guestPhone.Text = guest.Contact;
        }

        private void InitialLoad()
        {
            if (this.room != null && this.guest != null)
            {
                roomName.Text = room.Name;
                chargeFee.Text = room.Charge_Fee.ToString();
                guestName.Text = guest.Name;
                guestPhone.Text = guest.Contact;
            }
        }
    }
}
