using Microsoft.EntityFrameworkCore;
using Pet_Store;
using System;

namespace PetStore.Data
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<CatFood> CatFoods { get; set; }
        public DbSet<DogLeash> DogLeashes { get; set; }

    }
}
