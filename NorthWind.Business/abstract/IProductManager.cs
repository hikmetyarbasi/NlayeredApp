using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Concrete;

namespace NorthWind.Business.Abstract
{
    public interface IProductManager
    {
        List<Product> GetAll();
    }
}
