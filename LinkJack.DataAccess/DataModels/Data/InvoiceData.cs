using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.Logic.DataModels.Data
{
    public class InvoiceData
    {
        public string InvoiceId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discout { get; set; }
        public List<InvoiceItemData> Items { get; set; }
        public string OrderId { get; set; }
        public string UserId { get; set; }
    }
}
