using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Concrete;

namespace NorthWind.DataAccess.Concrete
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                context.Products.Add(product);

                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                context.Entry(product);
                context.SaveChanges();
            }
        }
    }
}
