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
    [RoutePrefix("api/UserService")]
    public class UserController : ApiController
    {
        [Route("GetUsers")]
        [HttpPost]
        public IList<UserData> GetUsers(UserSearchCriteria userSC)
        {
           UserLogic userLogic = new UserLogic();
           return userLogic.GetUsers(userSC);

        }
        [Route("GetAllUsers")]
        public IList<UserData> GetAllUsers()
        {
            UserLogic userLogic = new UserLogic();
            return userLogic.GetUsers();
        }
        [Route("UpdateUser")]
        [HttpPost]
        public void Update(UserData userData)
        {
            UserLogic userLogic = new UserLogic();
            userLogic.Update(userData);
        }
        [Route("SaveUser")]
        [HttpPost]
        public void Save(UserData userData)
        {
            UserLogic userLogic = new UserLogic();
            userLogic.Save(userData);
        }
        [Route("DeleteUser/{id}")]
        public void Delete(int id)
        {
            UserLogic userLogic = new UserLogic();
            userLogic.Delete(id);
        }
    }
}
