using LinkJack.DataAccess;
using LinkJack.DataAccess.DataModels.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LinkJack.Controllers
{
    [RoutePrefix("api/CategoryService")]

    public class CategoryController : ApiController
    {
        [Route("GetCategory/{id}")]        
        public CategoryData GetCategory(int id)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            return categoryLogic.GetCategory(id);

        }
        [Route("GetAllCategories")]
        public IList<CategoryData> GetGetCategories()
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            return categoryLogic.GetCategories();
        }
        [Route("UpdateCategory")]
        [HttpPost]
        public void Update(CategoryData categoryData)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            categoryLogic.Update(categoryData);
        }
        [Route("SaveCategory")]
        [HttpPost]
        public void Save(CategoryData categoryData)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            categoryLogic.Save(categoryData);
        }
        [Route("DeleteCategory")]
        public void Delete(int id)
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            categoryLogic.Delete(id);
        }
    }
}
