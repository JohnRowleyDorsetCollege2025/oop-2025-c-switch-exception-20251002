using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_c_switch_exception_20251002.Models
{
    internal class ExceptionDemos
    {
        public static void PrintTitle()
        {
            Console.WriteLine("Exception Demos");
        }

        public static void UnhandledExceptionDemo()
        {
           throw new Exception("This is an unhandled exception demo.");
        }
        public static void DivideByZeroFail()
        {
            int numerator = 10;
            int denominator = 0;
            int value = numerator / denominator;
        }
        public static void DivideNumbers(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution of DivideNumbers is complete.");
            }
        }
    }
}
