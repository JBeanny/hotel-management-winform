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
        private IStrategy<Room> RoomStrategy = new RoomStrategy();
        private List<Room> rooms = new List<Room>();

        public MainApplication()
        {
            InitializeComponent();
            rooms = RoomStrategy.Read();
            roomLabel.Text = rooms.Count.ToString();
            availableRoomLabel.Text = rooms.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm(rooms);
            roomForm.Show();
        }
    }
}
