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

        delegate Animal MyDeleg();

        delegate void MyDelegate(Dog d);


        static void Main(string[] args)
        {
            MyDel del = new MyDel(TestFunction); // outdated, only C# 1.x era

            MyDel dele = TestFunction; //better shorthand since C# 2.0

            dele += TestFunction2;
            Console.WriteLine(dele); //only has value returned by last method in invocation list of entire delegate.

            MyDeleg deleg = TestFunctionDog; //covariance

            MyDelegate delegi = TestFunctionAnimal; //contravariance

        }

        static string TestFunction()
        {
            return "Hi";
        }

        static string TestFunction2()
        {
            return "Bye";
        }
        static Dog TestFunctionDog()
        {
            return new Dog();
        }
        static void TestFunctionAnimal(Animal a)
        {

        }

    }

    
    class Animal
    {

    }
    class Dog : Animal
    {

    }
}
