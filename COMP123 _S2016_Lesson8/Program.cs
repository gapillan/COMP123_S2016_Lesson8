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
            int numerator = 5;
            int denominator = 10;

            try
            {
                float result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception exception)
            {

                Console.WriteLine("Error: " + exception.Message);
            }

            
        }
    }
}
