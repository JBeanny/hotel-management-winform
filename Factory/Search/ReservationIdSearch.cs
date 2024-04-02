

namespace HotelManagement.Factory.Search
{
    public class ReservationIdSearch : ISearch
    {
        private List<Reservation> reservations;
        public Reservation Search(string reservationId)
        {
            foreach (Reservation reservation in reservations)
            {
                if (reservation.Id == reservationId)
                {
                    return reservation;
                }
            }

            return null;
        }

        public ReservationIdSearch(List<Reservation> reservations)
        {
            this.reservations = reservations;
        }
    }
}
