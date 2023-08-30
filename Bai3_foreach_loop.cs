using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_foreach_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du vong lap foreach: ");
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(10);
            }

            Console.WriteLine("This is result: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

    }
}
