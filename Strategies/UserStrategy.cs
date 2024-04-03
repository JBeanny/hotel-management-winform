using HotelManagement.Models;

namespace HotelManagement
{
    public class UserStrategy : IStrategy<User>
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

        public void Insert(User Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            dbContext.Users.Add(Data);
            dbContext.SaveChanges();
        }

        public List<User> Read()
        {
            var dbContext = DatabaseConfig.GetInstance().Users;

            List<User> users = dbContext.ToList();

            return users;
        }

        public User ReadById(string username)
        {
            var dbContext = DatabaseConfig.GetInstance().Users;

            var user = dbContext.Where(col => col.username == username).ToList();

            if (user.Count > 0)
            {
                return user[0];
            }

            return null;
        }

        public void Update(string Id, User Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var userToUpdate = dbContext.Users.Find(Id);

            if (userToUpdate != null)
            {
                dbContext.Users.Update(userToUpdate);
                dbContext.SaveChanges();
            }
        }
    }
}