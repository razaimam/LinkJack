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
        [HttpPost]
        public IList<UserData> GetAllUsers()
        {
            UserLogic userLogic = new UserLogic();
            return userLogic.GetUsers();
        }
    }
}
