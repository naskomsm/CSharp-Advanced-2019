using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program // 80-100
    {
        static void Main(string[] args)
        {
            SortedSet<string> reservationList = new SortedSet<string>();
            SortedSet<string> guestsComing = new SortedSet<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (input == "PARTY") // this stupid cunts come to the party
                {
                    break;
                }

                else
                {
                    if (input.Length == 8)
                    {
                        reservationList.Add(input);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (input.Length == 8)
                {
                    guestsComing.Add(input);
                }
            }

            int count = 0;
            foreach (var cunt in reservationList)
            {
                if (!guestsComing.Contains(cunt))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            foreach (var cunt in reservationList.OrderBy(x=> char.IsLetter(x[0])).ThenBy(x => char.IsUpper(x[0])))
            {
                if (!guestsComing.Contains(cunt))
                {
                    Console.WriteLine(cunt);
                }
            }
        }
    }
}
