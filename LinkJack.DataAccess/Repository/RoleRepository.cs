using LinkJack.DataAccess.Repository.Interface;
using LinkJack.Logic.DataModels.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.Repository
{
    class RoleRepository: IRepository<RoleData>
    {
        DBEntities dbContext;
        private bool disposed = false;
        public RoleRepository()
        {
            dbContext = new DBEntities();
        }
        public IList<RoleData> GetAll()
        {
            var role = dbContext.Roles.ToList();

            var roleData = role
                .Select(r => new RoleData
                {
                    RoleId = r.roleId,
                    RoleType = r.roleType,
                    RoleDesc = r.roleDesc
                }).ToList();

            return roleData;
        }

        public RoleData Get(string id)
        {
            var role = dbContext.Roles.Find(id);
            if (role != null)
            {
                return new RoleData
                {
                    RoleId = role.roleId,
                    RoleType = role.roleType,
                    RoleDesc = role.roleDesc
                };
            }

            return null;
        }
        public IList<RoleData> GetCategoryByType(string name)
        {
            var role = dbContext.Roles.Where(r => r.roleType.Contains(name)).Take(10).ToList();

            var roleData = role
                .Select(r => new RoleData
                {
                    RoleId = r.roleId,
                    RoleType = r.roleType,
                    RoleDesc = r.roleDesc
                }).ToList();

            return roleData;

        }
        public void Save(RoleData roleData)
        {
          Role product =  dbContext.Roles.Add(
                new Role
                {
                    roleType = roleData.RoleType,
                    roleDesc = roleData.RoleDesc,
                    
                });

         
          dbContext.SaveChanges();

        }

        public void Delete(int id)
        {
           Role role = dbContext.Roles.Find(id);
           if (role != null)
           {
               dbContext.Roles.Remove(role);
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
