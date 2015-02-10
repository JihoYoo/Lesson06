using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_COMP123
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1("Hello");

            myClass.IntergerNumber = 10;
            myClass.DoubleNumber = 50.0;


            myClass.show();

            Console.Write("\n");

            Console.WriteLine("++++++++++++++++++++++++++");

            Console.WriteLine("Press hit any key to exit");

            Console.ReadKey();
        }
    }
}
