using System;
using System.Collections.Generic;
using System.Linq;

namespace qca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Quest!");

            try 
	        {

                System.Console.Write("\nEnter value to do opeartion on Fraction \n(Sample expression like (? 1/2 * 3_1/2) : ");
                string inputExpression = Console.ReadLine();
                Console.WriteLine("you entered " + inputExpression);

                if (inputExpression.Length > 0)
                {
                    var exp = Fraction.MathExpression(inputExpression);
                    var result = Fraction.OutputInFraction(exp);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("enter value to do operations on fraction" + inputExpression);
                }
            }
            catch (global::System.Exception)
	        {

		        throw;
	        }


        }
    }
}
