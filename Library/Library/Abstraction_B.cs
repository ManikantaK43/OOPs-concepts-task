using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Sponsor : SecondLibrary   //inherit the class School2
    {
        public override void Manager()    //using override keyword to access the abstract methods and classes
        {
            Console.WriteLine("");
        }
        public override void Author()
        {
            Console.WriteLine("");
        }
    }
}
