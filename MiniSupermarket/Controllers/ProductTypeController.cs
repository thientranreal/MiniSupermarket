using MiniSupermarket.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.Controllers
{
    internal class ProductTypeController
    {
        private ProductTypeModel model = new ProductTypeModel();

        public DataTable getAllProducts()
        {
            return model.getAllProducts();
        }

        public bool checkIdExist(string id) { return model.checkIdExist(id);}
        public bool checkNameExist(string name) { return model.checkNameExist(name);}

    }
}
