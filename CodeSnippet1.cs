using System;

namespace C838383
{
    //Write an OO C# program using Classes and 
    //    Methods to provide the functions of a CALCULATOR. 
    //    Add, Subtract, Multiple, Divide

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Calculator.Addition(2, 2));
            Console.WriteLine(Calculator.Subtraction(3, 4));
            Console.WriteLine(Calculator.Multiply(2, 2));
            Console.WriteLine(Calculator.Devide(3, 4));

            Calculator calc1 = new Calculator();
            Console.Write("the answer is {0}", calc1.Addition(84, 3333));

        }
    }

    class Calculator
    {
        // How to write a METHOD:
        // visibility modifier : public in development; after working: we might change to private
        // method has a RETURN TYPE
        // always has (parameters = even if ZER0)

        // static means: I call the METHOD on the CLASS, NOT on an OBJECT of the Class
        // my parameters need to have data types: str, int

        public float Addition(float input1, float input2)
        {
            return input1 + input2;
        }

        public static float Subtraction(float input1, float input2)
        {
            return input1 - input2;
        }

        public static float Multiply(float input1, float input2)
        {
            return input1 * input2;
        }

        public static float Devide(float input1, float input2)
        {
            return input1 / input2;
        }
    }

}
