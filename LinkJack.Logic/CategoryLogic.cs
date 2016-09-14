using LinkJack.DataAccess.DataModels.Data;
using LinkJack.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess
{
    public class CategoryLogic
    {
        CategoryRepository repository;
        public IList<CategoryData> GetCategories()
        {
            repository = new CategoryRepository();
            return repository.GetAll();
        }
        public CategoryData GetCategory(int id)
        {
            repository = new CategoryRepository();
            return repository.Get(id);
        }
        public IList<CategoryData> GetCategoryByName(string name)
        {
            repository = new CategoryRepository();
            return repository.GetCategoryByName(name);
        }
        public void Save(CategoryData categoryData)
        {
            repository = new CategoryRepository();
            repository.Save(categoryData);
        }
        public void Update(CategoryData categoryData)
        {
            repository = new CategoryRepository();
            repository.Save(categoryData);
        }
        public void Delete(int id)
        {
            repository = new CategoryRepository();
            repository.Delete(id);
        }
    }
}
