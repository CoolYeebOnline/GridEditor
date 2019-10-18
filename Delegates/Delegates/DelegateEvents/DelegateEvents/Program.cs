using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
    class MainClass
    {


       
        public delegate void CallEverybody();
        public event CallEverybody CallEverybodyEvent;

        public void PleaseCallEveryone()
        {
            Console.WriteLine("Main class please call everyone called : calling even \"CallEverybodyEvent\" ");
            CallEverybodyEvent();
        }
        
    }
}
