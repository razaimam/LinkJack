using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LinkJack.Logic.DataModels.Data;
using LinkJack.Logic.DataModels.DataFilters;

namespace LinkJack.Controllers
{
    [RoutePrefix("ProductService")]
    public class ProductController : ApiController
    {
        [Route("GetProduct")]
        [HttpPost]
        public List<ProductData> GetProduct(ProductSearchCriteria prdSC)
        {
            return  null;           
        
        }
    }
}
