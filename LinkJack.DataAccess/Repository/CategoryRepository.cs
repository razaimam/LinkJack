using LinkJack.DataAccess.Repository.Interface;
using LinkJack.DataAccess.DataModels.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LinkJack.DataAccess.Repository
{
    public class CategoryRepository : IRepository<CategoryData>
    {
        DBEntities dbContext;
        private bool disposed = false;
        public CategoryRepository()
        {

        }
        public IList<CategoryData> GetAll()
        {
            using (dbContext = new DBEntities())
            {
                var category = dbContext.Categories.ToList();

                var categoryData = category
                    .Select(c => new CategoryData
                    {
                        CategoryId = c.categoryId,
                        CategoryName = c.categoryName,
                        CategoryType = c.categoryType,
                        Desc = c.categoryDesc
                    }).ToList();

                return categoryData;
            }
        }

        public CategoryData Get(int id)
        {
            using (dbContext = new DBEntities())
            {
            var category = dbContext.Categories.Find(id);
            if (category != null)
            {
                return new CategoryData
                {
                    CategoryId = category.categoryId,
                    CategoryName = category.categoryName,
                    CategoryType = category.categoryType,
                    Desc = category.categoryDesc
                };
            }

                }
            return null;
        }
        public IList<CategoryData> GetCategoryByName(string name)
        {
            using (dbContext = new DBEntities())
            {
                var category = dbContext.Categories.Where(p => p.categoryName.Contains(name)).Take(10).ToList();

                var categoryData = category
                    .Select(c => new CategoryData
                    {
                        CategoryId = c.categoryId,
                        CategoryName = c.categoryName,
                        CategoryType = c.categoryType,
                        Desc = c.categoryDesc
                    }).ToList();

                return categoryData;
            }

        }
        public void Save(CategoryData categoryData)
        {
            using (dbContext = new DBEntities())
            {
                Category product = dbContext.Categories.Add(
                      new Category
                      {
                          categoryName = categoryData.CategoryName,
                          categoryDesc = categoryData.Desc,
                          categoryType = categoryData.CategoryType
                      });


                dbContext.SaveChanges();

            }
        }

        public void Update(CategoryData categoryData)
        {
            using (dbContext = new DBEntities())
            {
                Category category = dbContext.Categories.Add(
                      new Category
                      {
                          categoryName = categoryData.CategoryName,
                          categoryDesc = categoryData.Desc,
                          categoryType = categoryData.CategoryType
                      });

                dbContext.Entry(category).State = EntityState.Modified;
                dbContext.SaveChanges();

            }
        }

        public void Delete(int id)
        {
            using (dbContext = new DBEntities())
            {
                Category category = dbContext.Categories.Find(id);
                if (category != null)
                {
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                }
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
