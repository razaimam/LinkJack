using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.DataFilters
{
    public class CustomerSearchCriteria
    {
        enum SearchType { CustomerId = 1, Name_DOB = 2};
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDate { get; set; }
    }
}
