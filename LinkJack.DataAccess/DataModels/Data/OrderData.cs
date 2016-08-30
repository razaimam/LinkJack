using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.Logic.DataModels.Data
{
    public class OrderData
    {
        public string CustomerId { get; set; }
        public string UserId { get; set; }
        public  List<ProductOrderData> Products { get; set; }


    }
}
