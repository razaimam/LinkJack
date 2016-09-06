using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.DataFilters
{
    public enum ProductSearchType { None = 0, ProductId, CategoryId, ProductName }
    public class ProductSearchCriteria
    {
        public ProductSearchType SearchType { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }

    }
}
