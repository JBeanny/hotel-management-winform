namespace HotelManagement
{
    public class Guest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public Guest(string id,string name,string contact,string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Contact = contact;
            this.Gender = gender;
        }
        public Guest() { }
    }
}