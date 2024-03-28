﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HotelManagement
{
    // Singleton Pattern
    public static class DatabaseConfig
    {
        private static DatabaseContext _instance;
        private static string _databaseConnectionString = "Data Source=localhost; Initial Catalog=HotelManagement; User Id=sa; Password=aVeryStrongPassword!@;TrustServerCertificate=True";

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