using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Principal1
    {
        public static void Main(string[] args)
        {
           
           GovernmentLibrary obj = new GovernmentLibrary(); 
            obj.Manager();       
            obj.Manager("");
            obj.Manager("", 1);
        }
    }
}
