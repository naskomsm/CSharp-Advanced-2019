namespace _01._Crossroads
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            int carPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    Console.WriteLine($"Everyone is safe.");
                    Console.WriteLine($"{carPassed} total cars passed the crossroads.");
                    break;
                }

                if (input == "green") // cars start passing
                {
                    int secondsToPass = greenLight;
                    int additionalSeconds = freeWindow;


                    while (queue.Any())
                    {
                        string currentCar = queue.Peek();

                        if (currentCar.Length <= secondsToPass + additionalSeconds)
                        {
                            for (int i = 0; i < secondsToPass; i++)
                            {
                                if (currentCar != string.Empty)
                                {
                                    currentCar = currentCar.Remove(0, 1);
                                }
                            }
                        }


                        if (currentCar == string.Empty) // a car passed
                        {
                            carPassed++;
                            secondsToPass -= queue.Peek().Length;
                            queue.Dequeue();
                            continue;
                        }

                        else if (currentCar != string.Empty)
                        {
                            if (secondsToPass + additionalSeconds >= currentCar.Length)
                            {
                                carPassed++;
                                secondsToPass -= queue.Peek().Length;
                                additionalSeconds -= queue.Peek().Length;
                                queue.Dequeue();
                                continue;
                            }
                            else if (secondsToPass > 0)
                            {
                                // to do the crash
                                Console.WriteLine($"A crash happened!");
                                for (int i = 0; i < secondsToPass + additionalSeconds; i++)
                                {
                                    currentCar = currentCar.Remove(0, 1);
                                }

                                Console.WriteLine($"{queue.Peek()} was hit at {currentCar[0]}.");
                                return;
                            }
                            else
                            {
                                break;
                            }
                        }


                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}
