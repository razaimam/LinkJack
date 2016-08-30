using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.Logic.DataModels.Data
{
    public class AddressData
    {
        public string FloorNumber { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string StreeNumber { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public bool IsDefault { get; set; }

    }
}
