using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.Data
{
    public class InvoiceData
    {
        public int? InvoiceId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discout { get; set; }
        public List<InvoiceItemData> Items { get; set; }
        public int? OrderId { get; set; }
        public int? UserId { get; set; }
    }
}
