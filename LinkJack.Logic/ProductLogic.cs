
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkJack.DataAccess.DataModels.Data;
using LinkJack.DataAccess.DataModels.DataFilters;
using LinkJack.DataAccess.Repository.Interface;
using LinkJack.DataAccess.Repository;
namespace LinkJack.Logic
{
    public class ProductLogic
    {
        ProductRepository repository;
        public IList<ProductData> getProducts()
        {
            repository = new ProductRepository();
            return repository.GetAll();
        }

        public IList<ProductData> getProducts(ProductSearchCriteria searchCriteria)
        {
            IList<ProductData> ProductList = null;
            repository = new ProductRepository();
            switch(searchCriteria.SearchType)
            {
                case ProductSearchType.None:
                    ProductList = new List<ProductData>();
                    break;
                case ProductSearchType.ProductId:    
                    ProductList = new List<ProductData>();
                    ProductList.Add(repository.Get(searchCriteria.ProductId));
                    break;
                case ProductSearchType.CategoryId:
                    ProductList = repository.GetProductsByCategory(searchCriteria.CategoryId);
                    break;
                case ProductSearchType.ProductName:
                    ProductList = repository.GetProductByName(searchCriteria.ProductName);
                    break;
            }
            return ProductList;
        }
    }
}
