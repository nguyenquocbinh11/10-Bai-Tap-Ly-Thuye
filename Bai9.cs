using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai9
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isError;

            do
            {
                isError = false;

                try
                {
                    Console.Write("Nhap so: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Loi so. Lam on thu lai lan nua!");
                    isError = true;
                }

            } while (isError);

            Console.Write("So cua ban: {0}", n);


        }
    }
}
