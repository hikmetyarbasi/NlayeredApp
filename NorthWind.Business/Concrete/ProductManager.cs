using NorthWind.DataAccess.Concrete;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Business.Abstract;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete.EntityFrameWork;

namespace NorthWind.Business.Concrete
{
    public class ProductManager : IProductManager
    {
        private IProductDal _productDal;
        

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

    }
}
