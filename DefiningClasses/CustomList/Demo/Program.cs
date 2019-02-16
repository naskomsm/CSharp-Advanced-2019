using System;

namespace Demo
{
    public class Program
    {
        static void Main()
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(4);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(5);

            list.RemoveAt(0);
            list.RemoveAt(5);
            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
         

        }
    }
}
