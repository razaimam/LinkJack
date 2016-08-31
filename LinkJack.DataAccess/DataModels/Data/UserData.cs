using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.Data
{
    public class UserData
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int? Attempt { get; set; }
        public string CustomerId { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Email { get; set; }
        public int? StatusId { get; set; }
        public string RoleId { get; set; }

    }
}
