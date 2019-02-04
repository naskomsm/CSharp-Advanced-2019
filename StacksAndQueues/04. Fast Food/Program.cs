using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] ordersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(ordersArray);
            Queue<int> originalOrders = new Queue<int>(orders);

            int sum = 0;
            while (orders.Any())
            {
                if (sum + orders.Peek() <= quantityOfFood)
                {
                    sum += orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Any() == false)
            {
                Console.WriteLine(originalOrders.Max());
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(originalOrders.Max());
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
