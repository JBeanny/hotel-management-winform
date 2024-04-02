using HotelManagement.Bridge;
using HotelManagement.Observer;
using Microsoft.IdentityModel.Tokens;

namespace HotelManagement
{
    public partial class ReservationForm : Form
    {
        ReservationDetailForm reservationDetailForm = null;
        private IStrategy<Reservation> ReservationStrategy = new ReservationStrategy();
        private IStrategy<Guest> GuestStrategy = new GuestStrategy();

        private List<RoomAvailable> availableRooms = new List<RoomAvailable>();
        private Room selectedRoom = null;
        private List<Room> rooms = new List<Room>();
        private List<Reservation> reservations = new List<Reservation>();
        private Guest filledGuest = new Guest();

        public ReservationForm(List<Room> rooms, List<Reservation> reservations)
        {
            InitializeComponent();
            this.rooms = rooms;
            this.reservations = reservations;
            this.availableRooms = filterAvailableRooms();
            dataGridView1.SelectionChanged += handleRowSelection;
            this.startDatePicker.Value = DateTime.Today;
            this.endDatePicker.Value = DateTime.Today.AddDays(1);
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
            string reservationId = Utils.generateRandomId(5, "R");
            Reservation newReservation = new Reservation(reservationId, selectedRoom.Id, filledGuest.Id, startDate, endDate, "0");
            ReservationStrategy.Insert(newReservation);

            // Add to reservation list to filter the available room
            reservations.Add(newReservation);
            //refetchAvailableRooms(sender, e);
            MainApplication.reservationSubject.Notify("reserve", reservations);

            reservationDetailForm = new ReservationDetailForm(selectedRoom, filledGuest, newReservation);
            reservationDetailForm.Show();
        }

        private void InitialLoad(object sender, EventArgs e)
        {
            if (availableRooms.Count > 0)
            {
                // set selected room to be the first one
                this.selectedRoom = availableRooms[0].GetRoom();

                // loop through every available rooms and then put into the data grid view
                availableRooms.ForEach(room =>
                {
                    AvailableRoomDataGridViewFormat(room.GetRoom());
                });
            }
        }

        // Filter Available room by selected period of DateTime
        private List<RoomAvailable> filterAvailableRooms()
        {
            List<RoomAvailable> availableRooms = new List<RoomAvailable>();

            foreach (Room room in this.rooms)
            {
                RoomAvailable roomReservation = new RoomAvailable(room, reservations.Find(x => x.RoomId == room.Id));

                // find available rooms between the start date and end date
                if (roomReservation.IsAvailable(startDatePicker.Value.Date) && roomReservation.IsAvailable(endDatePicker.Value.Date))
                {
                    availableRooms.Add(roomReservation);
                }
            }

            return availableRooms;
        }


        // Get Guest Information
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

            if (isChecked)
            {
                return radioButton1.Text;
            }
            else
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
                string roomId;
                if (!selectedRow.Cells[0].Value.ToString().IsNullOrEmpty())
                {
                    roomId = selectedRow.Cells[0].Value.ToString();
                    string name = selectedRow.Cells[1].Value?.ToString();
                    float chargeFee;
                    if (float.TryParse(selectedRow.Cells[2].Value?.ToString(), out chargeFee))
                    {
                        selectedRoom = new Room(roomId, name, chargeFee);
                    }
                }
            }
        }

        // Format to insert into Data Grid View
        private void AvailableRoomDataGridViewFormat(Room room)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = room.Id.ToString();
            row.Cells[1].Value = room.Name;
            row.Cells[2].Value = room.Charge_Fee.ToString();
            dataGridView1.Rows.Add(row);
        }

        // handle start date value changed to fetch the available room 
        private void startDateValueChanged(object sender, EventArgs e)
        {
            refetchAvailableRooms(sender, e);
        }

        // handle end date value changed to fetch the available room 
        private void endDateValueChanged(object sender, EventArgs e)
        {
            refetchAvailableRooms(sender,e);
        }

        private void refetchAvailableRooms(object sender, EventArgs e)
        {
            availableRooms = filterAvailableRooms();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            InitialLoad(sender, e);
        }
    }
}
