namespace _01._Key_Revolver
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int price = int.Parse(Console.ReadLine());
            int barrel = int.Parse(Console.ReadLine());

            int[] bulletsInfo = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locksInfo = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int money = int.Parse(Console.ReadLine());


            Stack<int> bullets = new Stack<int>(bulletsInfo);
            Queue<int> locks = new Queue<int>(locksInfo);

            int bulletsCount = 0;
            int reloadingTime = 0;

            while (bullets.Any() && locks.Any())
            {
                int currentBullet = bullets.Peek();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine($"Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                }
                else
                {
                    Console.WriteLine($"Ping!");
                    bullets.Pop();
                }
                reloadingTime++;
                bulletsCount++;

                if (reloadingTime == barrel && bullets.Any())
                {
                    Console.WriteLine($"Reloading!");
                    reloadingTime = 0;
                    continue;
                }
            }
            if(bullets.Any() && !locks.Any())
            {
                int moneyEarned = money - (bulletsCount * price);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else if(!bullets.Any() && locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = money - (bulletsCount * price);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
