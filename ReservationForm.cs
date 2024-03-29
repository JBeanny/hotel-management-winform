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
    public partial class ReservationForm : Form
    {
        ReservationDetailForm reservationDetailForm = null;
        private List<Room> availableRooms = new List<Room>();
        private Room selectedRoom = new Room();

        public ReservationForm(List<Room> availableRooms)
        {
            this.availableRooms = availableRooms;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservationDetailForm = new ReservationDetailForm();
            reservationDetailForm.Show();
        }

        private void InitialLoad(object sender, EventArgs e)
        {
            availableRooms.ForEach(room =>
            {
                AvailableRoomDataGridViewFormat(room);
            });
        }

        private void AvailableRoomDataGridViewFormat(Room room)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = room.Id.ToString();
            row.Cells[1].Value = room.Name;
            row.Cells[2].Value = room.Charge_Fee.ToString();
            dataGridView1.Rows.Add(row);
        }
    }
}
