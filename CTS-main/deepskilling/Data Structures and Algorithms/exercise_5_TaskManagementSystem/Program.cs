using System;

class Program
{
    static void Main()
    {
        TaskLinkedList list = new TaskLinkedList();

        list.AddTask(new Task(101, "Design UI", "Pending"));
        list.AddTask(new Task(102, "Write Code", "In Progress"));
        list.AddTask(new Task(103, "Testing", "Completed"));

        list.TraverseTasks();

        Console.WriteLine();

        list.SearchTask(102);

        Console.WriteLine();

        list.DeleteTask(102);

        list.TraverseTasks();
    }
}
