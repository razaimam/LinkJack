using LinkJack.DataAccess.DataModels.Data;
using LinkJack.DataAccess.DataModels.DataFilters;
using LinkJack.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace LinkJack.Controllers
{
    [RoutePrefix("ProductService")]
    public class ProductController : ApiController
    {
        [Route("GetProducts")]
        [HttpPost]
        public IList<ProductData> GetProductS(ProductSearchCriteria prodSC)
        {
            ProductLogic prodLogic = new ProductLogic();
            return prodLogic.getProducts(prodSC);
        
        }
        [Route("GetAllProducts")]
        [HttpPost]
        public IList<ProductData> GetAllProduct()
        {
            ProductLogic prodLogic = new ProductLogic();
            return prodLogic.getProducts();
        }
    }
}
