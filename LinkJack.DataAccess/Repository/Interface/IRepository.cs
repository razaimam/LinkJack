using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace LinkJack.DataAccess.Repository.Interface
{
    interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity Get(string id);
        void Save(TEntity model);
        void Delete(int id);
    }
}
