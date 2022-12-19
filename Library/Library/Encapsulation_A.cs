using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class School6
    {
        static void Main(string[] args)
        {
            Reader obj = new Reader();
            //setting values to the properties
            obj.MembershipNumber = "x0124151";
            obj.Name = "Satyajith";
            obj.Level = "4";

            //getting values
            Console.WriteLine("ID =" + obj.MembershipNumber);
            Console.WriteLine("Name = " + obj.Name);
            Console.WriteLine("Standard =" + obj.Level);
        }
    }
}
