using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double input, input2;
            
            Console.WriteLine("Enter your GPA.");
            input = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter your test score.");
            input2 = Convert.ToDouble(Console.ReadLine());

            if (input >= 3.0 && input2 >= 60)
                Console.WriteLine("Accept");
            else if (input < 3.0 && input2 >= 80)
                Console.WriteLine("Accept");
            else
                Console.WriteLine("Reject");
        }
    }
}
