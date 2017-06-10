using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetList();
        T GetItem(int id);
        void Create(T item);
        void Update(T item);
        void Save();
    }
}
