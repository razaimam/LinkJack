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
    public class RoleRepository: IRepository<RoleData>
    {
        DBEntities dbContext;
        private bool disposed = false;
        public RoleRepository()
        {
           
        }
        public IList<RoleData> GetAll()
        {
            using (dbContext = new DBEntities())
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
        }

        public RoleData Get(int id)
        {
            using (dbContext = new DBEntities())
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
            }
            return null;
        }
        public IList<RoleData> GetRoleByType(string name)
        {
            using (dbContext = new DBEntities())
            {
                var role = dbContext.Roles.Where(r => r.roleType.Contains(name)).ToList();

                var roleData = role
                    .Select(r => new RoleData
                    {
                        RoleId = r.roleId,
                        RoleType = r.roleType,
                        RoleDesc = r.roleDesc
                    }).ToList();

                return roleData;
            }
        }
        public void Save(RoleData roleData)
        {
            using (dbContext = new DBEntities())
            {
                Role product = dbContext.Roles.Add(
                      new Role
                      {
                          roleType = roleData.RoleType,
                          roleDesc = roleData.RoleDesc,

                      });


                dbContext.SaveChanges();

            }
        }
        public void Update(RoleData roleData)
        {
            using (dbContext = new DBEntities())
            {
                Role product = dbContext.Roles.Attach(
                      new Role
                      {
                          roleType = roleData.RoleType,
                          roleDesc = roleData.RoleDesc,

                      });

                dbContext.Entry(product).State = EntityState.Modified;
                dbContext.SaveChanges();

            }
        }

        public void Delete(int id)
        {
            using (dbContext = new DBEntities())
            {
                Role role = dbContext.Roles.Find(id);
                if (role != null)
                {
                    dbContext.Roles.Remove(role);
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
