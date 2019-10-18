using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass main = new MainClass();
            SecondClass second = new SecondClass();

            second.Subscribe(main);

            main.PleaseCallEveryone();

            Console.ReadKey();
        }
    }
}
