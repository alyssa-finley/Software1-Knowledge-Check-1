using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store
{
    internal class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, CatFood> _catFood;


        public ProductLogic()
        {
            _products = new List<Product>
            {
                new DogLeash
                {
                    Name = "Nylon Dog Leash",
                    Price = 20,
                    Quantity = 0,
                    Description = "A six foot nylon dog leash",
                    LengthInches = 72,
                    Material = "Nylon"
                },
                new CatFood
                {
                    Name = "Hill's Science Diet",
                    Price = 60,
                    Quantity = 10,
                    Description = "A fourteen pound bag of cat food",
                    WeightPounds = 14,
                    KittenFood = false
                }
            };
            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood)
            {
                _catFood.Add(product.Name, product as CatFood);
            }
            _products.Add(product); 
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeash[name];
            }
            catch (Exception)
            {
                return null;

            } 
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _products.InStock().Select(x => x.Name).ToList();
        }

        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(x => x.Price).Sum();
        }

    }
}
