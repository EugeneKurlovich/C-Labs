using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    public class buyer
    {
        public int  buyerId { get; set; }
        public string Name { get; set; }

        public virtual List<Goods> Orders { get; set; }

        public override string ToString()
        {
            return buyerId + "  " + Name;
        }
    }

    public class Goods
    {
        public int GoodsId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Customer { get; set; }

        public override string ToString()
        {
            return GoodsId + "  " + ProductName + "  " + Quantity + "  " + Customer;
        }
    }

    class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("MyShop")
        { }

        public DbSet<buyer> buyers { get; set; }
        public DbSet<Goods> goodss { get; set; }
    }
}
