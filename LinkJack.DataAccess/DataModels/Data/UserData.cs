using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.Logic.DataModels.Data
{
    public class UserData
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Attempt { get; set; }
        public string CustomerId { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
