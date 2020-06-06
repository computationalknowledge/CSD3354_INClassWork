using System;

namespace C838383
{
    // illustrate 4 kinds of memory variables 
    // and variable scope and visibility

    class Program
    {
        static void Main(string[] args)
        {
            // let's practice using RECURSION
            // remember recursion is a METHOD CALLING ITSELF!
            new Tangerine().IAmRecurive();


        }
    }

    class Tangerine
    {
        public void IAmRecurive()
        {
            IAmRecurive();
        }

    }

 
}
