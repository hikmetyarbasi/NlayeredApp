using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;

namespace NorthWind.DataAccess.Concrete.EntityFrameWork
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthWindContext>, IProductDal
    {

    }
}
