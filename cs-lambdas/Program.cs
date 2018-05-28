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

            //events
            Person p = new Person();

            //i want to be notified when this person gets $100+.
            // to do this, i'm going to subscribe 
            // use multicast syntax 
            // we're holding reference to this function behind the scenes.

            //THIS MAKES US A SUBSCRIBER:
            p.cashEvent += P_cashEvent; //press "tab tab" for autocomplete after typing +=

            p.AddCash(50);

            p.AddCash(50);

            // ----

            //alternatively could do like this:
            p.cashEvent += () => Console.WriteLine("has over 100 dollary doos");




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

        private static void P_cashEvent()
        {
            Console.WriteLine("PERSON HAS GAINED 100 DOLLARS");
            //throw new NotImplementedException();
        }

        class Person
        {
            public delegate void MyEventHandler(); 
            public event MyEventHandler cashEvent; 

            private int cash;

            public int Cash
            {
                get
                {
                    return cash;
                }
                set
                {
                    //can breakpoint here to watch step-by-step.
                    cash = value;

                    if (cash >= 100)
                    {
                        //let our subscribers know! 
                        if (cashEvent != null)
                        {
                            //if there are no subscribers.. then the event would be null..
                            cashEvent();
                        }
                    }
                }
            }

            public void AddCash(int amount)
            {
                Cash += amount;
            }
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
