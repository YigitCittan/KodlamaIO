using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);

    }
}
