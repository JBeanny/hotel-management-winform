using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelManagement
{
    public class RoomStrategy : IStrategy<Room>
    { 
        public void Delete(string Id)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var guestToDelete = dbContext.Rooms.Find(Id);

            if (guestToDelete != null)
            {
                dbContext.Rooms.Remove(guestToDelete);
                dbContext.SaveChanges();
            }
        }

        public void Insert(Room Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            dbContext.Rooms.Add(Data);
            dbContext.SaveChanges();
        }

        public List<Room> Read()
        {
            var dbContext = DatabaseConfig.GetInstance().Rooms;

            List<Room> rooms = dbContext.ToList();

            return rooms;
        }

        public Room ReadById(string Id)
        {
            var dbContext = DatabaseConfig.GetInstance().Rooms;

            var room = dbContext.Find(Id);

            if (room != null)
            {
                return room;
            }

            return null;
        }

        public void Update(string Id, Room Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var roomToUpdate = dbContext.Rooms.Find(Id);

            if (roomToUpdate != null)
            {
                dbContext.Rooms.Update(roomToUpdate);
                dbContext.SaveChanges();
            }
        }
    }
}