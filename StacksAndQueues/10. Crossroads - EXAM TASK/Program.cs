using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int carPassed = 0;
            var queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    int currentDuration = greenDuration;
                    if (queue.Count != 0)
                    {
                        while (currentDuration > 0)
                        {
                            string currentCar = queue.Peek();
                            if (currentCar.Length <= currentDuration)
                            {
                                carPassed++;
                                currentDuration -= queue.Dequeue().Length;
                                if (queue.Count == 0)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                currentCar = currentCar.Substring(currentDuration, currentCar.Length - currentDuration);
                                if (currentCar.Length <= freeWindow)
                                {
                                    queue.Dequeue();
                                    carPassed++;
                                    break;
                                }
                                else
                                {

                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{queue.Dequeue()} was hit at {currentCar[freeWindow]}.");
                                    return;
                                }
                            }
                        }

                    }

                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carPassed} total cars passed the crossroads.");
        }
    }
}