using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store
{
    internal interface IProductLogic
    {
        /// <summary>
        /// Adding a product 
        /// </summary>
        /// <param name="product">The product to be added</param>
        public void AddProduct(Product product);
        /// <summary>
        /// Get a list of all products 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts();
        /// <summary>
        /// Returns the product dog leash by name 
        /// </summary>
        /// <param name="name">The name of the dog leash</param>
        /// <returns></returns>
        public DogLeash GetDogLeashByName(string name);
        /// <summary>
        /// Returns in stock products 
        /// </summary>
        /// <returns></returns>
        public List<string> GetOnlyInStockProducts();
    }

}
