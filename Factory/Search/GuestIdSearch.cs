

namespace HotelManagement.Factory.Search
{
    public class GuestIdSearch : ISearch
    {
        private List<Reservation> reservations;
        public Reservation Search(string guestId)
        {
            foreach(Reservation reservation in reservations)
            {
                if(reservation.GuestId == guestId)
                {
                    return reservation;
                }
            }

            return null;
        }

        public GuestIdSearch(List<Reservation> reservations)
        {
            this.reservations = reservations;
        }
    }
}
