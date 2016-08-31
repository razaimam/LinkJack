using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.DataModels.DataFilters
{
    public class ProductSearchCriteria
    {
        public string ProductId { get; set; }
        public string CategoryId { get; set; }
        public bool isProductIdSpecified { get; set; }
        public bool isCategoryIdSpecified { get; set; }

    }
}
