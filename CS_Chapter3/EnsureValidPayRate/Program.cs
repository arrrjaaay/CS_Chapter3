using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, input2, num, num2;
            double pay, number, number2, number3, weekly;
            Console.WriteLine("Input a hourly pay rate.");
            input = Console.ReadLine();
            pay = Convert.ToDouble(input);

            weekly = pay * 40;
            num = weekly.ToString("C");
            number2 = 49.99;
            num2 = number2.ToString("C");
            number = 5.65;

            if (pay < number || pay > number2)
            {
                Console.WriteLine("Enter number again.");
                input2 = Console.ReadLine();
                number3 = Convert.ToDouble(input2);
                if (number3 < number || number3 > number2)
                {
                    Console.WriteLine("Error.");
                }
            }
            else
                Console.WriteLine("Hourly pay rate is {0} and weekly pay rate is {1}", num, num2);
        }
    }
}
