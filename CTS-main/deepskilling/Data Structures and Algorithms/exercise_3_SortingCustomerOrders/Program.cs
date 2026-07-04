using System;

class Program
{
    static void Main()
    {
        Order[] orders =
        {
            new Order(101,"Rahul",2500),
            new Order(102,"Priya",1000),
            new Order(103,"Arjun",4500),
            new Order(104,"Sneha",1800)
        };

        Console.WriteLine("Bubble Sort");

        SortingOperations.BubbleSort(orders);

        foreach(Order order in orders)
        {
            order.Display();
        }

        Console.WriteLine();

        Order[] orders2 =
        {
            new Order(101,"Rahul",2500),
            new Order(102,"Priya",1000),
            new Order(103,"Arjun",4500),
            new Order(104,"Sneha",1800)
        };

        Console.WriteLine("Quick Sort");

        SortingOperations.QuickSort(
            orders2,
            0,
            orders2.Length - 1);

        foreach(Order order in orders2)
        {
            order.Display();
        }
    }
}
