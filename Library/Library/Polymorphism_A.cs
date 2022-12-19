using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Polymorphism
/// </summary>
namespace Library
{
    public class GovernmentLibrary
    {
        /// <summary>
        /// -------creating methods
        /// </summary>

        public void Manager()
        {
            Console.WriteLine("I'm the manager here");
        }

        /// <summary>
        /// ----using method overloading
        /// </summary>

        public void Manager(string value)   
        {
            Console.WriteLine(value + "Manager");
        }
        public void Manager(string value, int value1)  
        {
            Console.WriteLine(value + " " + value1);
        }
    }
}

