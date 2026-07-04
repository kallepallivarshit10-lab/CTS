using System;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Mouse","Electronics"),
            new Product(103,"Keyboard","Electronics"),
            new Product(104,"Shoes","Fashion"),
            new Product(105,"Watch","Accessories")
        };

        Console.WriteLine("Linear Search");

        Product result1 =
            SearchOperations.LinearSearch(products,103);

        if(result1 != null)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine(result1.ProductName);
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search");

        Product result2 =
            SearchOperations.BinarySearch(products,104);

        if(result2 != null)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine(result2.ProductName);
        }
    }
}
