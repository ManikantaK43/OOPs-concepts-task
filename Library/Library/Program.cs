using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        string Organization = "GyanSys Infotech";

        public void Name(string a, string b)
        {
            Organization = a + b;
        }
        public void stdName()
        {
            Console.WriteLine("Organization" + Organization);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("this is");
            Program objName = new Program(); 

            objName.stdName(); 
        }
    }
}
