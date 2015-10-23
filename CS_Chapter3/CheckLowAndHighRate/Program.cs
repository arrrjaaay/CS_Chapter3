using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, num, num2;
            double pay, number, number2;
            Console.WriteLine("Input a hourly pay rate.");
            input = Console.ReadLine();
            pay = Convert.ToDouble(input);

            number = 5.65;
            num = number.ToString("C");

            number2 = 49.99;
            num2 = number2.ToString("C");

            if (pay < number || pay > number2)
            {
                Console.WriteLine("Error: Pay rate does not fall between {0} or {1}.", num, num2);
            }
            else
            {
                Console.WriteLine("Pay rate falls between {0} and {1}.", num, num2);
            }
        }
    }
}
