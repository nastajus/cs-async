using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_delegates
{
    class Program
    {
        delegate string MyDel();

        static void Main(string[] args)
        {
            MyDel del = new MyDel(TestFunction); // outdated, only C# 1.x era

            MyDel dele = TestFunction; //better shorthand since C# 2.0

            del += TestFunction2;
            Console.WriteLine(del); //only has value returned by last method in invocation list of entire delegate.

        }

        static string TestFunction()
        {
            return "Hi";
        }

        static string TestFunction2()
        {
            return "Bye";
        }

    }

}
