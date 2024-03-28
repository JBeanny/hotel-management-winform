using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HotelManagement
{
    // Singleton Pattern
    public static class DatabaseConfig
    {
        private static DatabaseContext _instance;
        private static string _databaseConnectionString = "Data Source=localhost; Initial Catalog=e5; User Id=sa; Password=Hourmeng12;Integrated Security=True";

        public static DatabaseContext GetInstance()
        {
            // if _instance is null, then connect to DB then return
            if (_instance == null)
            {
                // Assuming appsettings.json approach
                /*var configurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                var configuration = configurationBuilder.Build();
                var connectionString = configuration.GetConnectionString("MyConnectionString");*/

                _instance = new DatabaseContext(new DbContextOptionsBuilder<DatabaseContext>()
                   .UseSqlServer(_databaseConnectionString) // Replace with your provider if needed
                   .Options);
            }

            return _instance;
        }
    }
}