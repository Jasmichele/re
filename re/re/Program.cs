using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace re
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a # for Fibonacci");
            string num = Console.ReadLine();
            int intNum = Convert.ToInt32(num);



            for (int n = intNum; n > 0; n--)
            {
                for (int i = n; i > 0; i--)
                {
                    if (i < n && i > 0)
                        Console.Write("*");
                    Console.Write(string.Format("{0}", i));
                }
                Console.WriteLine(string.Format(": {0}", Fac(n)));
            }

            //Fib(0, 1, 1, intNum);
            Console.ReadLine();
        }

        //static void Fib(int a, int b, int c, int intNum)
        //{
        //    Console.WriteLine(a);

        //    if (c < intNum)
        //    {
        //        Fib(b, a + b, c + 1, intNum);
        //    }

        //}

        static int Fac(int intNum)
        {

            if (intNum - 1 > 0)
            {

                return intNum * Fac(intNum - 1);
            }

            return 1;

        }
    }
}
