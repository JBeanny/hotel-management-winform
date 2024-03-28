using System.Linq;

namespace HotelManagement
{
    public class GuestStrategy : IStrategy<Guest>
    { 
        public void Delete(int Id)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var guestToDelete = dbContext.Guests.Find(Id);
        }

        public void Insert(Guest Data)
        {
            var dbContext = DatabaseConfig.GetInstance();
           
            dbContext.Guests.Add(Data);
        }

        public List<Guest> Read()
        {
            throw new NotImplementedException();
        }

        public Guest ReadById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Guest Data)
        {
            throw new NotImplementedException();
        }
    }
}