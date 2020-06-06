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
            new Tangerine().IAmRecurive(5);


        }
    }

    class Tangerine
    {
        public void IAmRecurive(int Factorial)
        {
            int Product = 1 ; 
            
            if (Factorial == 1) { return; }
            Product *= Factorial;
            Factorial--;
            // am I still in the method?  I have "returned" out of it??
            // in this case I execute another recursion!

            IAmRecurive(Factorial);
            Console.WriteLine("factorial is {0}", Factorial);
        }

    }

 
}
