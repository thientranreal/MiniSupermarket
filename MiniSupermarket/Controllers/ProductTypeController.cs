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
        public bool addProductType(string name, string id = null) { return model.addProductType(name, id);}
        public bool deleteProductType(string id) { return model.deleteProductType(id);}

        public bool updateProductType(string id, string name) { return model.updateProductType(id, name); }
        public string[] getNameForSuggestionBox() { return model.getNameForSuggestionBox(); }
        public string[] getIdForSuggestionBox() { return model.getIdForSuggestionBox(); }
        public DataTable getProductsByName(string name) { return model.getProductsByName(name); }

        public DataTable getProductsById(string id) { return model.getProductsById(id); }
    }
}
