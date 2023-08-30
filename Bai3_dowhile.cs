using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_dowhile
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vi du vong lap do while: ");
            do
            {
                Console.Write("Enter number: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);
            Console.Write("Alright");
            Console.Read();
        }
    }
}
