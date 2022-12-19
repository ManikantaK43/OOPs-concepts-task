using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Inheritance
    {
          public static void Main(string[] args)
        {
            Library obj = new Library(); //creating object using the  child class
            obj.Reader();       //calling methods 
            obj.Employee();
            obj.NonFictional();
        }
    }
    }

