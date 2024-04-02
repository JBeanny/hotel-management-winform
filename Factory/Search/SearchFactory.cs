
namespace HotelManagement.Factory.Search
{
    public class SearchFactory
    {
        private List<Reservation> reservations = new List<Reservation>();

        public SearchFactory(List<Reservation> reservations)
        {
            this.reservations = reservations;
        }

        public enum SearchType
        {
            Reservation,
            Guest
        }

        public ISearch CreateSearch(SearchType type)
        {
            switch (type)
            {
                case SearchType.Reservation:
                    return new ReservationIdSearch(reservations);
                case SearchType.Guest:
                    return new GuestIdSearch(reservations);
                default:
                    throw new ArgumentException("Invalid search type");
            }
        }
    }
}
