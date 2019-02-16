namespace ListyOperator
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            var listyiterator = new ListyIterator<string>(new System.Collections.Generic.List<string>());
            while (true)
            {
                string input = Console.ReadLine();
               

                if(input == "END")
                {
                    break;
                }

                string[] splittedInput = input.Split();

                string command = splittedInput[0];

                if(command == "Create")
                {
                    listyiterator = new ListyIterator<string>(splittedInput.Skip(1).ToList());
                }
                else if (command == "Move")
                {
                    Console.WriteLine(listyiterator.Move());
                }
                else if (command == "Print")
                {
                    Console.WriteLine(listyiterator.Print());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyiterator.HasNext());
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ",listyiterator));
                }


            }
        }
    }
}
