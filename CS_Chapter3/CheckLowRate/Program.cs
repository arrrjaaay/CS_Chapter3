using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double pay, number;
            Console.WriteLine("Input a hourly pay rate.");
            input = Console.ReadLine();
            pay = Convert.ToDouble(input);
            number = 5.65;
            if (pay < number)
            {
                Console.WriteLine("Error: Pay rate does not match ${0}.", number);
            }
            else
            {
                Console.WriteLine("Pay rate matches or is higher.");
            }
        }
    }
}
