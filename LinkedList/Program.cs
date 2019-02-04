namespace LinkedList
{
    using System;

    public class Program
    {
        static void Main()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.AddFirst(5);
            list.AddLast(251);

            list.ForEach(n => Console.WriteLine(n));
        }
    }
}
