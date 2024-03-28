namespace HotelManagement
{
    public class Reservation
    {
        public Room Room { get; set; }
        public Guest Guest { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean CheckIn { get; set; }
    }
}