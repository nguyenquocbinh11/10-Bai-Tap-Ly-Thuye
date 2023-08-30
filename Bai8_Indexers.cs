using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    public class Bai8_Indexers
    {
        int[] alnt;
        public Bai8_Indexers(int size)
        {

            alnt = new int[size];
        }

        public int this[int index]
        {
            get { return alnt[index]; }
            set
            {
                alnt[index] = value;
            }
        }

       
        static void Main(string[] args)
        {
            const int SIZE = 10;
            Bai8_Indexers b2 = new Bai8_Indexers(SIZE);
            Random rnd = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                b2[i] = rnd.Next(1, 20);
            }
            Console.WriteLine("Cac phan tu trong mang: ");
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(b2[i] + " ");
            }
            Console.Read();
        }
    }
}
