using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class User
    {
        public string Id {  get; set; }
        public string username {  get; set; }
        public string password { get; set; }
        public DateTime createdDateTime { get; set; }

        public User(string id,string username, string password)
        {
            this.Id = id;
            this.username = username;
            this.password = password;
            this.createdDateTime = DateTime.Now;
        }

        public User() { }
    }
}
