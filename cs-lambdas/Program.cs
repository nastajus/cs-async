using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lambdas
{
    class Program
    {
        delegate void CountIt();

        static void Main(string[] args)
        {
            //anonymous method
            CountIt testDel = delegate
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }

            };
            testDel();
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
