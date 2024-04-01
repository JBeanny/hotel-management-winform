using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Bridge
{
    public class RoomAvailable : RoomReservationAbstraction
    {
        private Room room { get;  }
        public RoomAvailable(Room room, IReservation reservation) : base(room, reservation)
        {
            this.room = room;
        }
        public override bool IsAvailable(DateTime dateTime)
        {
            if (Reservation == null)
            {
                return true;
            }

            if (Reservation.StartDate.CompareTo(dateTime) <= 0 && Reservation.EndDate.CompareTo(dateTime) > 0)
            {
                return false;
            }
            return true;
        }
        public override Room GetRoom()
        {
            return this.room;
        }
    }
}
