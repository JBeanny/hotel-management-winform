namespace HotelManagement
{
    public partial class ReservationForm : Form
    {
        ReservationDetailForm reservationDetailForm = null;
        private List<Room> availableRooms = new List<Room>();
        private Room selectedRoom = new Room();
        private Guest filledGuest = new Guest();

        public ReservationForm(List<Room> availableRooms)
        {
            InitializeComponent();

            this.availableRooms = availableRooms;
            dataGridView1.SelectionChanged += handleRowSelection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // handle data here with chain of responsibility design pattern
            string name = guestNameInput.Text;
            string contact = guestPhoneInput.Text;
            string id = guestIdInput.Text;
            filledGuest = new Guest(name, contact);

            reservationDetailForm = new ReservationDetailForm(selectedRoom, filledGuest);
            reservationDetailForm.Show();
        }

        private void InitialLoad(object sender, EventArgs e)
        {
            // set selected room to be the first one
            this.selectedRoom = availableRooms[0];

            // loop through every available rooms and then put into the data grid view
            availableRooms.ForEach(room =>
            {
                AvailableRoomDataGridViewFormat(room);
            });
        }

        // handle row selection
        private void handleRowSelection(object? sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow != null && selectedRow.Cells.Count > 2)
            {
                int roomId;
                if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out roomId))
                {
                    string name = selectedRow.Cells[1].Value?.ToString();
                    float chargeFee;
                    if (float.TryParse(selectedRow.Cells[2].Value?.ToString(), out chargeFee))
                    {
                        selectedRoom = new Room(roomId, name, chargeFee);
                    }
                }
            }
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
