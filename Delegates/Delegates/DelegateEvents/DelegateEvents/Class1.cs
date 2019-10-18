using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEvents
{
    class SecondClass
    {
        public void Subscribe(MainClass instance)
        {
            instance.CallEverybodyEvent += Called;
            Console.WriteLine("Second class subscribed to event in main class.");
        }
        public void Called()
        {
            Console.WriteLine("Second Class Called");
        }
    }

}
