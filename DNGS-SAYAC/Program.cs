using System;

namespace DNGS_SAYAC
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            for (int i = 1000; i >=0; i-=5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }
            Console.WriteLine("\n\n Elaman sayisi:{0}", sayac);
        }
    }
}
