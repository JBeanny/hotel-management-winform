namespace HotelManagement
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public Guest(string name,string contact)
        {
            this.Name = name;
            this.Contact = contact;
        }
        public Guest() { }
    }
}