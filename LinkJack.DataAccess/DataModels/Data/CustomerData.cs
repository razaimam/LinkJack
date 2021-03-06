﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.Data
{
    public class CustomerData
    {
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDate { get; set; }
        public List<AddressData> Addresses { get; set; }
    }
}
