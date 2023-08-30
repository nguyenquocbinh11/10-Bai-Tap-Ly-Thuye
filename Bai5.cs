using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai5
    {
        private string name, type, color;
        private int guarantee;

        public void input()
        {
            Console.Write("Enter motorbike name: ");
            name = Console.ReadLine();
            Console.Write("Enter motorbike type: ");
            type = Console.ReadLine();
            Console.Write("Enter motorbike color: ");
            color = Console.ReadLine();

            Console.Write("Enter motorbike guantantee: ");
            guarantee = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("\nInformation: ");
            Console.WriteLine("Motorbike name: " + name);
            Console.WriteLine("Motorbike type: " + type);
            Console.WriteLine("Motorbike color: " + color);
            Console.WriteLine("Motorbike guarantee: " + guarantee);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Bai5 motorbike = new Bai5();
            motorbike.input();
            motorbike.display();
        }
    }
}
