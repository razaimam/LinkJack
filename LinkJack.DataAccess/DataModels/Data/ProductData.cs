using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.Logic.DataModels.Data
{
    public class ProductData
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? InfoRegisterDate { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string ImagePath { get; set; }
        public string OfferText { get; set; }
        public string CategoryId { get; set; }
    }
}
