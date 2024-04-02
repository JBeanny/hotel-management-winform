using HotelManagement.Bridge;
using HotelManagement.Observer;

namespace HotelManagement
{
    public partial class MainApplication : Form
    {
        private RoomForm roomForm;
        private ReservationForm reservationForm;
        private GuestCheckInCheckOutForm guestCheckInCheckOut;
        private IStrategy<Room> RoomStrategy = new RoomStrategy();
        private IStrategy<Reservation> ReservationStrategy = new ReservationStrategy();

        private List<Room> rooms = new List<Room>();
        private List<Reservation> reservations = new List<Reservation>();
        private List<RoomAvailable> availableRooms = new List<RoomAvailable>();
        public static ReservationSubject reservationSubject = new ReservationSubject();
        public static RoomSubject roomEvent = new RoomSubject();
        private DashboardObserver dashboardObserver;

        public MainApplication()
        {
            InitializeComponent();

            // Read rooms data from DB
            rooms = RoomStrategy.Read();

            // Read reservations data from DB
            reservations = ReservationStrategy.Read();

            // Get Available Rooms
            availableRooms = filterAvailableRooms();

            roomLabel.Text = rooms.Count.ToString();
            availableRoomLabel.Text = availableRooms.Count.ToString();
            reservationLabel.Text = reservations.Count.ToString();


            // Observer subscribe
            dashboardObserver = new DashboardObserver(reservationLabel, roomLabel);
            reservationSubject.Subscribe(dashboardObserver);
            roomEvent.Subscribe(dashboardObserver);
        }

        private List<RoomAvailable> filterAvailableRooms()
        {
            List<RoomAvailable> availableRooms = new List<RoomAvailable>();

            foreach (Room room in rooms)
            {
                RoomAvailable roomReservation = new RoomAvailable(room, reservations.Find(match: x => x.RoomId == room.Id));
                if (roomReservation.IsAvailable(selectedDatePicker.Value.Date))
                {
                    availableRooms.Add(roomReservation);
                }
            }

            return availableRooms;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm(rooms);
            roomForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservationForm = new ReservationForm(rooms, reservations);
            reservationForm.Show();
        }

        private void MainApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guestCheckInCheckOut = new GuestCheckInCheckOutForm(reservations);
            guestCheckInCheckOut.Show();
        }

        private void selectedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Get Available Rooms
            availableRooms = filterAvailableRooms();
            availableRoomLabel.Text = availableRooms.Count.ToString();
        }
    }
}
