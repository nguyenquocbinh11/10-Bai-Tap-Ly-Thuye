using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai8_Property
    {
        private string title;
        public string TITTLE { get { return title; } set { title = value; } }

        static void Main(string[] args)
        {
            Bai8_Property b8p = new Bai8_Property();
            b8p.TITTLE = "Microsoft";
            Console.Write("Title: ", b8p.TITTLE);
           
            Console.Read();
        }
    }
}
