using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkJack.DataAccess.DataModels.Data;
using LinkJack.DataAccess.DataModels.DataFilters;
using LinkJack.DataAccess.Repository.Interface;
using LinkJack.DataAccess.Repository;

namespace LinkJack.Logic
{
    public class UserLogic
    {
        UserRepository repository;
        public IList<UserData> GetUsers()
        {
            repository = new UserRepository();
            return repository.GetAll();
        }

        public IList<UserData> GetUsers(UserSearchCriteria searchCriteria)
        {
            IList<UserData> UserList = null;
            repository = new UserRepository();
            switch (searchCriteria.SearchType)
            {
                case UserSearchType.None:
                    UserList = new List<UserData>();
                    break;
                case UserSearchType.UserId:
                    UserList = new List<UserData>();
                    UserList.Add(repository.Get(searchCriteria.UserId));
                    break;
                case UserSearchType.CustomerId:
                    UserList = new List<UserData>();
                    UserList.Add(repository.GetUserByCustomerId(searchCriteria.CustomerId));
                    break;
                case UserSearchType.Name:
                    UserList = repository.GetUserByName(searchCriteria.FirstName);
                    break;
                case UserSearchType.Name_DOB:
                    UserList = repository.GetUserByNameAndDOB(searchCriteria.FirstName,searchCriteria.MiddleName,searchCriteria.LastName,searchCriteria.BrithDate);
                    break;
            }
            return UserList;
        }
        public void Save(UserData userData)
        {
            repository = new UserRepository();
            repository.Save(userData);
        }
        public void Update(UserData userData)
        {
            repository = new UserRepository();
            repository.Save(userData);
        }
        public void Delete(int id)
        {
            repository = new UserRepository();
            repository.Delete(id);
        }
    }
}
