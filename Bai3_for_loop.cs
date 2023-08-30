using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_for_loop
    {
        static void Main(string[] args)
        {
            Console.Write("Vi du vong lap for: ");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
