using System;

namespace ConsoleApp_samid
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 3;
            //int b = 7;

            /*
            int a = 10;
            int b = 3;

            int t = a / b;
            int c = a % b;

            Console.WriteLine(t);
            Console.WriteLine(c);


            Console.ReadKey();
            */
            /*
            int a = 12345;
            int cem = 0;
            int b = 98765;
            int hasil = 1;
            int deyishen = a % 10;
            int qaliq;

                while (a > 0)
            {
                qaliq = a % 10;
                a = (a - qaliq) / 10;
                cem = cem + qaliq;

            }
                while (b > 0)
            {
                qaliq = b % 10;
                b = (b - qaliq) / 10;
                hasil = hasil * qaliq;
            }
            int c = cem + hasil + deyishen;
            Console.WriteLine(c);
            */
            Console.Write("c:");
            string deyerC = Console.ReadLine();
            double c = Convert.ToDouble(deyerC);
            double w = (9*c /5) + 32;
            Console.WriteLine(w);



        }
       
    }
}
