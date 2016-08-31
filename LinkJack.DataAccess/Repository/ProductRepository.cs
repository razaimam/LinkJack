using System;
using System.Collections.Generic;
using System.Linq;
using LinkJack.DataAccess.Repository.Interface;
using LinkJack.DataAccess.DataModels.Data;

namespace LinkJack.DataAccess.Repository
{
    class ProductRepository: IRepository<ProductData>
    {
        DBEntities dbContext;
        private bool disposed = false;
        public ProductRepository()
        {
            dbContext = new DBEntities();
        }
        public IList<ProductData> GetAll()
        {
            var products= dbContext.Products.ToList();

            var productData = products
                .Select(p => new ProductData
                {
                    ProductId = p.productId,
                    ProductName = p.productName,
                    ProductDesc = p.description,
                    Price = p.price,
                    EndDate = p.endDate,
                    StartDate = p.startDate,
                    InfoRegisterDate = p.infoRegDate,
                    ImagePath= p.Images.Where(i=>i.isActive == true).FirstOrDefault().path,
                    CategoryId= p.categoryId,
                    OfferText=p.offerText,
                    Discount= p.discount                               
                }).ToList();

            return productData;
        }

        public ProductData Get(string id)
        {
            var product = dbContext.Products.Find(id);
            if(product!=null)
            {
                return new ProductData
                {
                    ProductId = product.productId,
                    ProductName = product.productName,
                    ProductDesc = product.description,
                    Price = product.price,
                    EndDate = product.endDate,
                    StartDate = product.startDate,
                    InfoRegisterDate = product.infoRegDate,
                    ImagePath = product.Images.Where(i => i.isActive == true).FirstOrDefault().path,
                    CategoryId = product.categoryId,
                    OfferText = product.offerText,
                    Discount = product.discount
                };
            }

            return null;
        }
        public IList<ProductData> GetProductByName(string name)
        {
            var products = dbContext.Products.Where(p => p.productName.Contains(name)).Take(10).ToList();

            var productData = products
                .Select(p => new ProductData
                {
                    ProductId = p.productId,
                    ProductName = p.productName,
                    ProductDesc = p.description,
                    Price = p.price,
                    EndDate = p.endDate,
                    StartDate = p.startDate,
                    InfoRegisterDate = p.infoRegDate,
                    ImagePath = p.Images.Where(i => i.isActive == true).FirstOrDefault().path,
                    CategoryId = p.categoryId,
                    OfferText = p.offerText,
                    Discount = p.discount
                }).ToList();

            return productData;

        }
        public void Save(ProductData productData)
        {
          Product product =  dbContext.Products.Add(
                new Product
                {
                    productName = productData.ProductName,
                    categoryId = productData.CategoryId,
                    price = productData.Price,
                    discount = productData.Discount,
                    startDate = productData.StartDate,
                    endDate = productData.EndDate,
                    infoRegDate = productData.InfoRegisterDate,
                    offerText = productData.OfferText,
                    description = productData.ProductDesc,
                });

          Image image = dbContext.Images.Add(
              new Image
              {
                  isActive = true,
                  path = productData.ImagePath,
                  productId = product.productId,
                  
              });
          dbContext.SaveChanges();

        }

        public void Delete(int id)
        {
           Product product = dbContext.Products.Find(id);
           if(product!=null)
           {
               dbContext.Products.Remove(product);
               dbContext.SaveChanges();
           }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }       
    }
}
