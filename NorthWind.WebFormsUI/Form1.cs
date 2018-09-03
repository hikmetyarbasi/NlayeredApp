using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWind.Business.Abstract;
using NorthWind.Business.Concrete;
using NorthWind.DataAccess.Concrete.EntityFrameWork;
using NorthWind.DataAccess.Concrete.Nhibernate;

namespace NorthWind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductManager _manager;
        public Form1()
        {
            InitializeComponent();
            _manager = new ProductManager(new EfProductDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdViewProducts.DataSource = _manager.GetAll();
        }
    }
}
