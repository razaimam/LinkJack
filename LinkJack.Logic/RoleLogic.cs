using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkJack.DataAccess.Repository;
using LinkJack.DataAccess.DataModels.Data;

namespace LinkJack.DataAccess
{
    public class RoleLogic
    {
        RoleRepository  repository;
        public IList<RoleData> GetRoles()
        {
            repository = new RoleRepository();
            return repository.GetAll();
        }
        public RoleData GetRole(int id)
        {
            repository = new RoleRepository();
            return repository.Get(id);
        }
        public IList<RoleData> GetRoleByType(string name)
        {
            repository = new RoleRepository();
            return repository.GetRoleByType(name);
        }
        public void Save(RoleData roleData)
        {
            repository = new RoleRepository();
            repository.Save(roleData);
        }
        public void Update(RoleData roleData)
        {
            repository = new RoleRepository();
            repository.Save(roleData);
        }
        public void Delete(int id)
        {
            repository = new RoleRepository();
            repository.Delete(id);
        }
    }
}
