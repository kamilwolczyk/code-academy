using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex2.Objects
{
    class Warehouse
    {
        private List<Product> listOfProducts= new List<Product>();

        public void AddProduct(Product product)
        {
            if (CheckIfProductExists(product)) listOfProducts.FirstOrDefault(x => x.Name == product.Name).Count += product.Count;
            else listOfProducts.Add(product);
        }
        
        public void BuyProduct(Product product)
        {
            try
            {
                listOfProducts.FirstOrDefault(x => x.Name == product.Name).Count -= product.Count;
            }
            catch (Exception)
            {
                Console.WriteLine("There is no such a product.");
            }
            
            
        }
        private bool CheckIfProductExists(Product product)
        {
            foreach(Product p in listOfProducts)
            {
                if (p.Name==product.Name) return true;
            }
            return false;
        }
        
        public IEnumerable<Product> GetList()
        {
            return listOfProducts;
        }

     
        }
    }

