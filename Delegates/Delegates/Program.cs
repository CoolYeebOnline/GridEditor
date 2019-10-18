using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates
{
    class Program
    {
        public delegate int DelegateToCall(int counter, int abs);

        static void Main(string[] args)
        {
            DelegateToCall dFunction = new DelegateToCall(CallThis);

            int sumab = dFunction(8, 4);

            Console.WriteLine(" is " + sumab);
            Console.ReadKey();
        }

        static int CallThis(int counter, int abs)
        {
            Console.Write("The sum of " + counter + " + " + abs);
            return counter + abs;
        }

       // static int CallThis(int counter, int abs)
       // {
       //     Console.Write("The sum of " * counter * " Multiplied by " * abs);
       //     return counter * abs;
       // }
    }
}
