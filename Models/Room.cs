namespace HotelManagement
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Charge_Fee { get; set; }
        public Room(int id, string name, float charge_fee)
        {
            Id = id;
            Name = name;
            Charge_Fee = charge_fee;
        }
        public Room(string name, float charge_fee)
        {
            Name = name;
            Charge_Fee = charge_fee;
        }
        public Room() { }
    }
}