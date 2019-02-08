using System;

namespace Tupple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();

            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];

            Tuppple<string, string> firstTuple = new Tuppple<string, string>(name,address);


            string[] secondInput = Console.ReadLine().Split();

            string secondName = secondInput[0];
            int liters = int.Parse(secondInput[1]);

            Tuppple<string, int> secondTuple = new Tuppple<string, int>(secondName, liters);

            
            string[] thirdInput = Console.ReadLine().Split();

            int intNumber = int.Parse(thirdInput[0]);
            double doubleNumber = double.Parse(thirdInput[1]);

            Tuppple<int, double> thirdTuple = new Tuppple<int, double>(intNumber, doubleNumber);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}
