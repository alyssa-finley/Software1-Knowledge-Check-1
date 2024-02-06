using Pet_Store;
using System.Text.Json;
using System;

var productLogic = new ProductLogic();

string userInput = ShowMenuAndGetUserInput();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        var dogLeash = new DogLeash();
        {
            Console.WriteLine("Adding a new dog leash...");

            Console.Write("What is the name of the dog leash?");
            dogLeash.Name = Console.ReadLine();

            Console.Write("What is the price of the dog leash?");
            dogLeash.Price = decimal.Parse(Console.ReadLine());

            Console.Write("What is the quantity of leashes?");
            dogLeash.Quantity = int.Parse(Console.ReadLine());

            Console.Write("What is the description of the leash?");
            dogLeash.Description = Console.ReadLine();

            Console.Write("What is the length of the leash?");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());

            Console.Write("What is the material of the leash?");
            dogLeash.Material = Console.ReadLine();

            productLogic.AddProduct(dogLeash);
            Console.WriteLine("A new dog leash has been successfully added!");
        }
    }
    if (userInput == "2")
    {
        Console.WriteLine("Please write the name of the dog leash you are trying to locate:");
        var dogLeashName = Console.ReadLine();
        var dogLeash = productLogic.GetDogLeashByName(dogLeashName);
        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
        Console.WriteLine();

        if (dogLeash != null)
        {
            Console.WriteLine(dogLeashName);
        }
        else
        {
            Console.Write("The dog leash could not be found ");
        }
    }
    if (userInput == "3")
    {
        Console.WriteLine("The following items are in stock: ");
        var inStock = productLogic.GetOnlyInStockProducts();
        foreach (var item in inStock)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    if (userInput == "4")
    {
        Console.WriteLine($"The total dollar amount of items in inventory: {productLogic.GetTotalPriceOfInventory()}");
        Console.WriteLine();
    }
    userInput = ShowMenuAndGetUserInput();
}

    static string ShowMenuAndGetUserInput()
    {
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to locate a dog leash");
    Console.WriteLine("Press 3 to locate in stock items");
    Console.WriteLine("Press 4 to view the total dollar amount of items in stock");
    Console.WriteLine("Type 'exit' to quit");
    return Console.ReadLine();
    }

