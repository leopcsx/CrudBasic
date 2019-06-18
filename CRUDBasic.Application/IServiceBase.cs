using System.Collections.Generic;

namespace CRUDBasic.Application
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        IEnumerable<TEntity> GetAll();
    }
}