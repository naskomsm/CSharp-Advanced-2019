namespace _03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < linesCount; i++)
            {
                double line = double.Parse(Console.ReadLine());
                box.Add(line);
            }

            //int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int firstIndex = indexes[0];
            //int secondIndex = indexes[1];

            //Swap(box.Data, firstIndex, secondIndex);
            //Console.WriteLine(box);

            double element = double.Parse(Console.ReadLine());

            int count = GetCountOfGreaterElements(box.Data, element);
            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElements<T>(List<T> listWithData,T element)
            where T : IComparable
        {
            int count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Swap<T>(List<T> listWithData,int firstIndex , int secondIndex)
        {
            T temp = listWithData[firstIndex];
            listWithData[firstIndex] = listWithData[secondIndex];
            listWithData[secondIndex] = temp;
        }
    }
}
