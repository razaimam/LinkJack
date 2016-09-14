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
    [RoutePrefix("api/ProductService")]
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
        public IList<ProductData> GetAllProduct()
        {
            ProductLogic prodLogic = new ProductLogic();
            return prodLogic.getProducts();
        }

        [Route("UpdateProduct")]
        [HttpPost]
        public void Update(ProductData prodData)
        {
            ProductLogic prodLogic = new ProductLogic();
            prodLogic.Update(prodData);
        }
        [Route("SaveProduct")]
        [HttpPost]
        public void Save(ProductData prodData)
        {
            ProductLogic prodLogic = new ProductLogic();
            prodLogic.Save(prodData);
        }
        [Route("DeleteProduct/{id}")]
        public void Delete(int id)
        {
            UserLogic prodLogic = new UserLogic();
            prodLogic.Delete(id);
        }
    }
}
