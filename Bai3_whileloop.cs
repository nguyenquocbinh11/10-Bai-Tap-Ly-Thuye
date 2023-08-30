using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_whileloop
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.Write("Vi du vong lap While: ");
            while (i <= 5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.Read();
        }
    }
}
