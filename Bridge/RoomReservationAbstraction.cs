using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Bridge
{
    public abstract class RoomReservationAbstraction
    {
        protected IRoom Room;
        protected IReservation Reservation;

        public RoomReservationAbstraction(IRoom Room, IReservation Reservation)
        {
            this.Room = Room;
            this.Reservation = Reservation;
        }

        public abstract bool IsAvailable(DateTime dateTime);
        public abstract Room GetRoom();
    }
}
