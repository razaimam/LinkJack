using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.DataFilters
{
    public enum UserSearchType { None = 0, CustomerId = 1, UserId, Name, Name_DOB };
    public class UserSearchCriteria
    {
        public UserSearchType SearchType { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDate { get; set; }
    }
}
