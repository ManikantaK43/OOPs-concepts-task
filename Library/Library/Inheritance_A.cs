using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : Genere //inheriting from the base class Deaprtment
    {
        public void Reader()
        {
            Console.WriteLine("Reading is my hobby");
        }

        public void Employee()
        {
            Console.WriteLine("I work Here");
        }
    }
}
