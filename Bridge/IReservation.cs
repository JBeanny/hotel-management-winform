using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Bridge
{
    public interface IReservation
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int RoomId { get; }
    }
}
