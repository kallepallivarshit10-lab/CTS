using System;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        Product p1 = new Product(101, "Laptop", 20, 55000);

        Product p2 = new Product(102, "Mouse", 100, 500);

        inventory.AddProduct(p1);
        inventory.AddProduct(p2);

        Console.WriteLine();

        inventory.DisplayProducts();

        inventory.UpdateProduct(101, 30);

        Console.WriteLine();

        inventory.DisplayProducts();

        inventory.DeleteProduct(102);

        Console.WriteLine();

        inventory.DisplayProducts();
    }
}
