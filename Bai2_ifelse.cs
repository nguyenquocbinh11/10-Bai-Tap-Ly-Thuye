using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai2_ifelse
    {
        static void Main(string[] args)
        {
            float avgScore;
            Console.Write("Enter Average Score: ");
            avgScore = float.Parse(Console.ReadLine());

            if (avgScore < 5)
            {
                Console.Write("bellow");
            }
            else if (avgScore < 6.5)
            {
                Console.Write("Average");
            }
            else if (avgScore < 8)
            {
                Console.Write("Good");
            }

            else
                Console.Write("Excellent");
            Console.Read();
        }
    }
}
