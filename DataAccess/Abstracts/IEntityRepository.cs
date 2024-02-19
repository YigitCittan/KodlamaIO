using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity.Abstracts;
using System.Threading.Tasks;
namespace DataAccess.Abstracts
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GettAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
