using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int[] temp = array;
            Console.WriteLine("Vi du ve Mang: ");
            Console.Write("Day la mang ban dau: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rnd.Next(1, 20);
            }

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Array.Sort(temp);
            Console.Write("Mang sau khi sap xep: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }
    }
}
