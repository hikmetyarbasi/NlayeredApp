using NorthWind.DataAccess.Concrete;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

    }
}
