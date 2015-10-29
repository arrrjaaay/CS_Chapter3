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
            string input, input2, hour, week, hour2, week2;
            double pay, low, high, pay2, weekly, weekly2;
            Console.WriteLine("Input a hourly pay rate.");
            input = Console.ReadLine();
            pay = Convert.ToDouble(input);
            hour = pay.ToString("C");
            weekly = pay * 40;
            week = weekly.ToString("C");
            
            high = 49.99;
            low = 5.65;

            if (pay < low || pay > high)
            {
                Console.WriteLine("Enter number again.");
                input2 = Console.ReadLine();
                pay2 = Convert.ToDouble(input2);
                weekly2 = pay2 * 40;
                hour2 = pay2.ToString("C");
                week2 = weekly2.ToString("C");
                if (pay2 < low || pay2 > high)
                {
                    Console.WriteLine("Error.");
                }
                else
                Console.WriteLine("Hourly pay rate is {0} and weekly pay rate is {1}", hour2, week2);
            }
            else
                Console.WriteLine("Hourly pay rate is {0} and weekly pay rate is {1}", hour, week);
        }
    }
}
