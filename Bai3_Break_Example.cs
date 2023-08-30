using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_Break_Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du vong lap foreach: ");
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 20);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nThis is result: ");

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    break;
                }
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
