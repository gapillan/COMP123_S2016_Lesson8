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
            Divide();
        }
         
        private static float Divide(int numerator, int denominator) 
        {

            //int numerator = 5;
            //int denominator = 10;

            try
            {
                // double result = Convert.ToDouble(numerator) / Convert.ToDouble(denominator); <-- if using double
                float result = Convert.ToSingle(numerator) / Convert.ToSingle(denominator); // <-- if using float 
                Console.WriteLine("Result: " + result);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                return 0f;
            }
        }
    }
}
