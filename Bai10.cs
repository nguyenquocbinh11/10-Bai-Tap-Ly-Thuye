using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai10
    {
        public delegate float Calc(float so1, float so2);

        float Cong(float so1, float so2)
        {
            return (so1 + so2);
        }
        
        static void Main(string[] args)
        {
            float so1 = 5.5f;
            float so2 = 13.5f;

            Bai10 b10 = new Bai10();
            Calc cl = new Calc(b10.Cong);
            float red = cl(so1, so2);

            Console.Write("{0} + {1} = {2}", so1, so2, red);
            Console.Read();
        }
    }
}
