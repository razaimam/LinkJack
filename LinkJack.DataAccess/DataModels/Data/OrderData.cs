using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.Data
{
    public class OrderData
    {
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public  List<ProductOrderData> Products { get; set; }


    }
}
