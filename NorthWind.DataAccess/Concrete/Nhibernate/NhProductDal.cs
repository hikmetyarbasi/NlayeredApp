using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete.EntityFrameWork;
using NorthWind.Entities.Concrete;

namespace NorthWind.DataAccess.Concrete.Nhibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return new List<Product>()
            {
                new Product()
                {
                    CategoryId = 1,
                    ProductId = 2,
                    ProductName = "Kitaplık",
                    QuantityPerUnit = "",
                    SupplierId = 12,
                    UnitPrice = 12.3m,
                    UnitsInStock = 3300,
                    UnitsOnOrder = 44
                }
            };
        }

        public void Add(Product entry)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entry)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entry)
        {
            throw new NotImplementedException();
        }
    }
}
