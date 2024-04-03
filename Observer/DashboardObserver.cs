using HotelManagement.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Observer
{
    public class DashboardObserver : IObserver
    {
        private readonly DateTime selectedDatePicker;
        private readonly Label reservateLabel;
        private readonly Label roomLabel;
        private readonly Label availableRoomLabel;
        private readonly Label dateReservation;
        private List<RoomAvailable> roomAvailables;
        public DashboardObserver(DateTime selectedDatePicker,Label reservateLabel, Label roomLabel, Label availableRoomLabel, Label dateReservation)
        {
            this.selectedDatePicker = selectedDatePicker;
            this.reservateLabel = reservateLabel;
            this.roomLabel = roomLabel;
            this.availableRoomLabel = availableRoomLabel;
            this.dateReservation = dateReservation;
        }
        public void Update(ISubject subject)
        {
            if(subject.Action == "reserve")
            {
                List<Reservation> reservations = (subject as ReservationSubject).Reservations;
                reservateLabel.Text = reservations.Count.ToString();
                int availableRooms = int.Parse(availableRoomLabel.Text);
                availableRoomLabel.Text = (availableRooms - 1).ToString();
                dateReservation.Text = reservations.FindAll(x => x.StartDate <= selectedDatePicker && x.EndDate > selectedDatePicker).ToList().Count.ToString();
            }

            if (subject.Action == "build")
            {
                roomLabel.Text = (subject as RoomSubject).Rooms.Count.ToString();
            }
        }
    }
}
