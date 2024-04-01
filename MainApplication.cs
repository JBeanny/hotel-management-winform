using HotelManagement.Bridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private List<RoomAvailable> filterAvailableRooms()
        {
            List<RoomAvailable> availableRooms = new List<RoomAvailable>();

            foreach (Room room in rooms)
            {
                RoomAvailable roomReservation = new RoomAvailable(room, reservations.Find(x => x.RoomId == room.Id));
                if (roomReservation.IsAvailable(new DateTime()))
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
            reservationForm = new ReservationForm(availableRooms);
            reservationForm.Show();
        }

        private void MainApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guestCheckInCheckOut = new GuestCheckInCheckOutForm();
            guestCheckInCheckOut.Show();
        }
    }
}
