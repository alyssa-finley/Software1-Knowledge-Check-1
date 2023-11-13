using System;
using System.Text.Json;
using Petpalooza;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        var dogLeash = new DogLeash();

        Console.WriteLine("New dog leash... ");

        Console.Write("What is the name of the dog leash: ");
        dogLeash.Name = Console.ReadLine();

        Console.Write("Enter the price of the dog leash: ");
        dogLeash.Price = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the number of dog leashes: ");
        dogLeash.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Describe the dog leash: ");
        dogLeash.Description = Console.ReadLine();

        Console.Write("Enter the length of the dog leash in inches: ");
        dogLeash.LengthInches = int.Parse(Console.ReadLine());

        Console.Write("Enter the material of the dog leash: ");
        dogLeash.Material = Console.ReadLine();

        Console.WriteLine(JsonSerializer.Serialize(dogLeash));

    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}

namespace Petpalooza 
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
    class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }

    class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }
}
