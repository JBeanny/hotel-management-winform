using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Bridge
{
    public abstract class RoomAvailableAbstraction
    {
        protected IReservation Reservation;

        public RoomAvailableAbstraction(IReservation Reservation)
        {
            this.Reservation = Reservation;
        }

        public abstract bool IsAvailable(DateTime dateTime);
        public abstract Room GetRoom();
    }
}
