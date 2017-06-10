using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    class SQLCustomerRepository : IRepository<buyer>
    {
        private CustomerContext db;
        public SQLCustomerRepository()
        {
            this.db = new CustomerContext();
        }
        public IEnumerable<buyer> GetList()
        {
            return db.buyers;
        }
        public buyer GetItem(int id)
        {
            return db.buyers.Find(id);
        }
        public void Create(buyer item)
        {
            db.buyers.Add(item);
        }
        public void Update(buyer item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            buyer customer = db.buyers.Find(id);
            if (customer != null)
                db.buyers.Remove(customer);


            Goods g = db.goodss.Find(id);
            if (g !=null)
            db.goodss.Remove(g);


        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                    db.Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
