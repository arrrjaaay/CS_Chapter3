using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            double pay, hours, gross, withhold=0, net;

            Console.WriteLine("Enter your hourly pay rate.");
            pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your hours worked.");
            hours = Convert.ToDouble(Console.ReadLine());
            gross = hours * pay;
            if (pay <= 300.0)
                withhold = .1;
            else if (pay > 300.0)
                withhold = .12;
            net = gross - (gross * withhold);
            n = net.ToString("C");
            Console.WriteLine("Your net pay is {0}.", n);
        }
    }
}
