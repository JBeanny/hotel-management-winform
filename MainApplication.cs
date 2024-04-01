using System;
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
        private List<Room> rooms = new List<Room>();
        private List<Room> availableRooms = new List<Room>();

        public MainApplication()
        {
            InitializeComponent();

            // Read rooms data from DB
            rooms = RoomStrategy.Read();
            availableRooms = rooms;

            roomLabel.Text = rooms.Count.ToString();
            availableRoomLabel.Text = rooms.Count.ToString();
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
