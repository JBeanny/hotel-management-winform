using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelManagement
{
    public class GuestStrategy : IStrategy<Guest>
    { 
        public void Delete(string Id)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var guestToDelete = dbContext.Guests.Find(Id);

            if (guestToDelete != null)
            {
                dbContext.Guests.Remove(guestToDelete);
                dbContext.SaveChanges();
            }
        }

        public void Insert(Guest Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            dbContext.Guests.Add(Data);
            dbContext.SaveChanges();
        }

        public List<Guest> Read()
        {
            var dbContext = DatabaseConfig.GetInstance().Guests;

            List<Guest> guests = dbContext.ToList();

            return guests;
        }

        public Guest ReadById(string Id)
        {
            var dbContext = DatabaseConfig.GetInstance().Guests;

            var guest = dbContext.Find(Id);

            if (guest != null)
            {
                return guest;
            }

            return null;
        }

        public void Update(string Id, Guest Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var guestToUpdate = dbContext.Guests.Find(Id);

            if (guestToUpdate != null)
            {
                dbContext.Guests.Update(guestToUpdate);
                dbContext.SaveChanges();
            }
        }
    }
}