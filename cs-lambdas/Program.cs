using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lambdas
{
    class Program
    {
        delegate int CountIt(int x);

        static void Main(string[] args)
        {
            //anonymous method
            CountIt testDel = delegate(int y)
            {
                int total = 0;
                for (int i = 0; i < 5; i++)
                {
                    total += y;
                    //Console.WriteLine(y);
                }
                return total;

            };
            int overallTotal = testDel(100);
            Console.WriteLine(overallTotal);
            //benefit: can only be used here, better as in-line.


            //CountIt testDel = TestFunction;
            //testDel();


            Console.ReadKey();
        }



        //static void TestFunction()
        //{
        //    for(int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
