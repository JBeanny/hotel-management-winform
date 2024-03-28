namespace HotelManagement
{
    public class Reservation
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public Guest Guest { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean CheckIn { get; set; }
        public Reservation(Room room,Guest guest,DateTime startDate,DateTime endDate,Boolean checkIn)
        {
            this.Room = room;
            this.Guest = guest;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CheckIn = checkIn;
        }
        public Reservation() { }
    }
}