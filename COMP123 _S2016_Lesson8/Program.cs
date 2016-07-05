using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123__S2016_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            try
            {

                Console.Write("Enter an Integer: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another Integer: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result: " + Divide(firstNumber, secondNumber));
            }
            catch (Exception exception) // <-- note: you do not necessarily need the exception bracket 
            {
                Console.WriteLine("Error: Invalid Input");
            }
        }
         
        private static float Divide(int numerator, int denominator) 
        {

            //int numerator = 5;
            //int denominator = 10;

            try
            {
                // double result = Convert.ToDouble(numerator) / Convert.ToDouble(denominator); <-- if using double
                // float result = Convert.ToSingle(numerator) / Convert.ToSingle(denominator); // <-- if using float
                int result =numerator / denominator;
                return result;
            }
            catch (Exception exception)
            {
                Console.Write("Error: " + exception.Message);
                return 0f;
            }
        }
    }
}
