using HotelManagement;

namespace HotelManagement
{
    public partial class ReservationForm : Form
    {
        ReservationDetailForm reservationDetailForm = null;
        private IStrategy<Reservation> ReservationStrategy = new ReservationStrategy();
        private IStrategy<Guest> GuestStrategy = new GuestStrategy();

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

            filledGuest = getGuestInfo();
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            // Insert guest
            GuestStrategy.Insert(filledGuest);

            // Generate and insert reservation
            string reservationId = Utils.generateRandomId(5,"R");
            Reservation newReservation = new Reservation(reservationId,selectedRoom.Id,filledGuest.Id,startDate,endDate,"0");
            ReservationStrategy.Insert(newReservation);

            reservationDetailForm = new ReservationDetailForm(selectedRoom, filledGuest,newReservation);
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

        private Guest getGuestInfo()
        {
            string guestName = guestNameInput.Text;
            string guestContact = guestPhoneInput.Text;
            string guestId = Utils.generateRandomId(5, "G");
            string guestGender = getGenderFromRadioButton();
            
            return new Guest(guestId, guestName, guestContact, guestGender);
        }

        // Get value from Radio button
        private string getGenderFromRadioButton()
        {
            Boolean isChecked = radioButton1.Checked;

            if(isChecked)
            {
                return radioButton1.Text;
            }else
            {
                return radioButton2.Text;
            }
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
