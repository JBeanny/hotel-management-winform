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
    public partial class RoomForm : Form
    {
        private IStrategy<Room> RoomStrategy = new RoomStrategy();
        private List<Room> rooms = new List<Room>();
        public RoomForm(List<Room> rooms)
        {
            this.rooms = rooms;

            InitializeComponent();
            addButton.Click += AddRoom;
        }

        private void AddRoom(object? sender, EventArgs e)
        {
            string name = nameInput.Text;
            float chargeFee = (float)chargeFeeInput.Value;
            Room newRoom = new Room(name, chargeFee);

            RoomStrategy.Insert(newRoom);
            MessageBox.Show("Inserted","Room Insertion",MessageBoxButtons.OK);
        }
    }
}
