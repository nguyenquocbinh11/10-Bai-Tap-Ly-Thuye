using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai6_Nguoi
    {
        private string maso;
        private string hoten;
        private string gioitinh;

        public Bai6_Nguoi(string maso, string hoten, string gioitinh)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ma so: ");
            maso = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("Information: ");
            Console.Write("Ma so: {0}, Ho va ten: {1}, Gioi tinh: {2}", maso, hoten, gioitinh);
            Console.Read();
        }
    }
}
