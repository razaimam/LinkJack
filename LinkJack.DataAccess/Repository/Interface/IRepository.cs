using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace LinkJack.DataAccess.Repository.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity Get(int id);
        void Save(TEntity model);
        void Delete(int id);
        void Update(TEntity model);
        
    }
}
