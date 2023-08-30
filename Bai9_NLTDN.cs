using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai9_NLTDN
    {

        public static void HienThiDiem(float avg)
        {
            if (avg < 0) { throw new Bai9_NLTDN_Exception("Average must be greater than zero"); }
            else
                Console.Write("Average score: {0}", avg);
        }

        static void Main(string[] args)
        {
            Bai9_NLTDN bai9 = new Bai9_NLTDN();
            try
            {
                HienThiDiem(7.1f);
                HienThiDiem(-1.2f);
                
            }
            catch(Bai9_NLTDN_Exception ex) {
                Console.WriteLine("\n{0}", ex.Message);
            }

            Console.Read();
        }
    }
}
