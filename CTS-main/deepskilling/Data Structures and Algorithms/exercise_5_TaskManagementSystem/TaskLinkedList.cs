using System;

public class TaskLinkedList
{
    private Task head = null;

    // Add Task
    public void AddTask(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
        }
        else
        {
            Task temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newTask;
        }

        Console.WriteLine("Task Added Successfully");
    }

    // Search Task
    public void SearchTask(int id)
    {
        Task temp = head;

        while (temp != null)
        {
            if (temp.TaskId == id)
            {
                Console.WriteLine("Task Found");
                temp.Display();
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Task Not Found");
    }

    // Traverse Tasks
    public void TraverseTasks()
    {
        Console.WriteLine("\nTask List");

        Task temp = head;

        while (temp != null)
        {
            temp.Display();
            temp = temp.Next;
        }
    }

    // Delete Task
    public void DeleteTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty");
            return;
        }

        if (head.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task Deleted Successfully");
            return;
        }

        Task current = head;
        Task previous = null;

        while (current != null && current.TaskId != id)
        {
            previous = current;
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Task Not Found");
            return;
        }

        previous.Next = current.Next;

        Console.WriteLine("Task Deleted Successfully");
    }
}
