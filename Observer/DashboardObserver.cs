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
        private readonly Label reservateLabel;
        private readonly Label roomLabel;
        private List<RoomAvailable> roomAvailables;
        public DashboardObserver(Label reservateLabel, Label roomLabel)
        {
            this.reservateLabel = reservateLabel;
            this.roomLabel = roomLabel;
        }
        public void Update(ISubject subject)
        {
            if(subject.Action == "reserve")
            {
                reservateLabel.Text = (subject as ReservationSubject).Reservations.Count.ToString();
            }

            if (subject.Action == "build")
            {
                roomLabel.Text = (subject as RoomSubject).Rooms.Count.ToString();
            }
        }
    }
}
