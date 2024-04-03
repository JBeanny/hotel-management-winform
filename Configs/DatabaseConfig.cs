using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HotelManagement
{
    // Singleton Pattern
    public static class DatabaseConfig
    {
        private static DatabaseContext _instance;
        private static string _databaseConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public static DatabaseContext GetInstance()
        {
            // if _instance is null, then connect to DB then return
            if (_instance == null)
            {
                _instance = new DatabaseContext(new DbContextOptionsBuilder<DatabaseContext>()
                   .UseSqlServer(_databaseConnectionString)
                   .Options);
            }

            return _instance;
        }
    }
}