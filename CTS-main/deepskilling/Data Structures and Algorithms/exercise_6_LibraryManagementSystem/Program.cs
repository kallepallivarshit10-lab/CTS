using System;

class Program
{
    static void Main()
    {
        Book[] books =
        {
            new Book(101,"C Programming","Dennis Ritchie"),
            new Book(102,"DBMS","Korth"),
            new Book(103,"Data Structures","Narasimha Karumanchi"),
            new Book(104,"Java","James Gosling"),
            new Book(105,"Python","Guido van Rossum")
        };

        Console.WriteLine("Linear Search");

        Book result1 = SearchOperations.LinearSearch(books, "Java");

        if (result1 != null)
        {
            result1.Display();
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search");

        Book result2 = SearchOperations.BinarySearch(books, "Python");

        if (result2 != null)
        {
            result2.Display();
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }
    }
}
