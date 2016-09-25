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
    [RoutePrefix("api/RoleService")]
    public class RoleController : ApiController
    {
        [Route("GetRole/{id}")]
        public RoleData GetRole(int id)
        {
            RoleLogic roleLogic = new RoleLogic();
            return roleLogic.GetRole(id);

        }
        [Route("GetAllRoles")]
        public IList<RoleData> GetAllUsers()
        {
            RoleLogic roleLogic = new RoleLogic();
            return roleLogic.GetRoles();
        }
        [Route("UpdateRole")]
        [HttpPost]
        public void Update(RoleData roleData)
        {
            RoleLogic roleLogic = new RoleLogic();
            roleLogic.Update(roleData);
        }
        [Route("SaveRole")]
        [HttpPost]
        public void Save(RoleData roleData)
        {
            RoleLogic roleLogic = new RoleLogic();
            roleLogic.Save(roleData);
        }
        [Route("DeleteRole/{id}")]
        public void Delete(int id)
        {
            RoleLogic roleLogic = new RoleLogic();
             roleLogic.Delete(id);
        }
    }
}
