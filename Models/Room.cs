namespace HotelManagement
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Charge_Fee { get; set; }
        public Room(string name, float charge_fee)
        {
            Name = name;
            Charge_Fee = charge_fee;
        }
        public Room() { }
    }
}