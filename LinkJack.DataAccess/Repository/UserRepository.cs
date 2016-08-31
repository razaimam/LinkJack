using LinkJack.DataAccess.Repository.Interface;
using LinkJack.DataAccess.DataModels.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkJack.DataAccess.Repository
{
    class UserRepository :IRepository<UserData>
    {
        DBEntities dbContext;
        private bool disposed = false;
        public UserRepository()
        {
            dbContext = new DBEntities();
        }
        public IList<UserData> GetAll()
        {
            var user = dbContext.Users.ToList();

            var userData = user
                .Select(u => new UserData
                {
                    
                    Attempt= u.attempts,
                    CreateDate= u.createDate,
                    CustomerId = u.Customer.customerId,
                    FirstName = u.Customer.firstName,
                    LastLogin=u.lastLogIn,                   
                    LastName = u.Customer.lastName,
                    MiddleName=u.Customer.middleName,
                    Password = u.password,
                    Email = u.email,
                    RoleId = u.roleId,
                    StatusId =u.statusId,
                    UserId = u.userId,
                    
                    
                }).ToList();

            return userData;
        }

        public UserData Get(string id)
        {
            var user = dbContext.Users.Find(id);
            if (user != null)
            {
                return new UserData
                {
                    Attempt = user.attempts,
                    CreateDate = user.createDate,
                    CustomerId = user.Customer.customerId,
                    FirstName = user.Customer.firstName,
                    LastLogin = user.lastLogIn,
                    LastName = user.Customer.lastName,
                    MiddleName = user.Customer.middleName,
                    Password = user.password,
                    Email = user.email,
                    RoleId = user.roleId,
                    StatusId = user.statusId,
                    UserId = user.userId,
                };
            }

            return null;
        }
        public IList<UserData> GetCategoryByName(string name)
        {
            var user = dbContext.Users.Where(u => u.Customer.firstName.Contains(name)||
                u.Customer.middleName.Contains(name) || u.Customer.lastName.Contains(name)).Take(10).ToList();

            var userData = user
                .Select(u => new UserData
                {

                    Attempt = u.attempts,
                    CreateDate =u.createDate,
                    CustomerId = u.Customer.customerId,
                    FirstName = u.Customer.firstName,
                    LastLogin = u.lastLogIn,
                    LastName = u.Customer.lastName,
                    MiddleName = u.Customer.middleName,
                    Password = u.password,
                    StatusId = u.statusId,
                    RoleId = u.roleId,
                    Email = u.email,
                    UserId = u.userId,
                    
                }).ToList();

            return userData;

        }
        public void Save(UserData userData)
        {
          Customer customer =  dbContext.Customers.Add(
                new Customer
                {
                    firstName = userData.FirstName,
                    middleName = userData.MiddleName,
                    lastName = userData.LastName                    
                });

          dbContext.Users.Add(
              new User
              {

                  attempts = userData.Attempt,
                  createDate = userData.CreateDate,
                  customerId = customer.customerId,
                  email = userData.Email,
                  lastLogIn =userData.LastLogin,
                  password = userData.Password,
                  roleId = userData.RoleId,
                  statusId =userData.StatusId,
                  
              });
         
          dbContext.SaveChanges();

        }

        public void Delete(int id)
        {
           User user = dbContext.Users.Find(id);
           Customer customer = dbContext.Users.Find(id).Customer;
           if (user != null && customer!=null)
           {
               dbContext.Users.Remove(user);
               dbContext.Customers.Remove(customer);
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
