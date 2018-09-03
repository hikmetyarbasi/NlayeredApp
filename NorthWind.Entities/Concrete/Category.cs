using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.DataAccess.Abstract;
using NorthWind.Entities.Abstract;

namespace NorthWind.Entities.Concrete
{
    public class Category : ICategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
