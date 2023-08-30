using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai2_switchcase
    {
        static void Main(string[] args)
        {
            string capability;
            Console.Write("Enter Capability: ");
            capability = Console.ReadLine();

            switch (capability.ToUpper())
            {
                case "A":
                    Console.Write("Android");
                    break;
                case "B":
                    Console.Write("Basic");
                    break;
                default:
                    Console.Write("none");
                    break;
            }
            Console.Read();
        }
    }  
}
