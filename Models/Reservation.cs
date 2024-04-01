using HotelManagement.Bridge;

namespace HotelManagement
{
    public class Reservation : IReservation
    {
        public string Id { get; set; }
        public int RoomId { get; set; }
        public string GuestId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CheckIn { get; set; }
        public Reservation(string id,int roomId,string guestId,DateTime startDate,DateTime endDate,string checkIn)
        {
            this.Id = id;
            this.RoomId = roomId;
            this.GuestId = guestId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CheckIn = checkIn;
        }
        public Reservation() { }
    }
}