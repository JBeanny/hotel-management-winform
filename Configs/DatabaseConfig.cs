using Microsoft.EntityFrameworkCore;

namespace HotelManagement
{
    // Singleton Pattern
    public static class DatabaseConfig
    {
        private static DatabaseContext _instance;
        private static string _databaseConnectionString = "Data Source=localhost; Initial Catalog=HotelManagement; User Id=sa; Password=Hourmeng12;TrustServerCertificate=True";

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