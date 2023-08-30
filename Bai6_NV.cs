using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai6_NV : Bai6_Nguoi
    {
        private string bangCap;
        public Bai6_NV(string maso, string hoten, string gioitinh) : base(maso, hoten, gioitinh)
        {
            this.bangCap = bangCap;
        }

        public sealed override void Input()
        {
            base.Input();
            Console.Write("Nhap bang cap: ");
            bangCap = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.Write("Bang cap: {0}", bangCap);
            Console.Read();
        }

        static void Main(string[] args)
        {
            Bai6_NV b6nv = new Bai6_NV("", "", "");
            b6nv.Input();
            b6nv.Display();
        }

    }
}
