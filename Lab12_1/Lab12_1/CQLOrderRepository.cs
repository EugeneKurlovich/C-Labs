using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    class CQLOrderRepository : IRepository<Goods>
    {
        private CustomerContext db;
        public CQLOrderRepository()
        {
            this.db=new CustomerContext();
        }
        public IEnumerable<Goods> GetList()
        {
            return db.goodss;
        }
        public Goods GetItem(int id)
        {
            return this.db.goodss.Find(id);
        }
        public void Create(Goods item)
        {
            db.goodss.Add(item);
        }
        public void Update(Goods item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Goods order = db.goodss.Find(id);
            if (order != null)
                db.goodss.Remove(order);
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
