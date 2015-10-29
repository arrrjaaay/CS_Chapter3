using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, pricep, priceo, pricem, incorrect;
            double something, pine, oak, mahogany;
            pine = 100;
            pricep= pine.ToString("C");
            oak = 225;
            priceo= oak.ToString("C");
            mahogany = 310;
            pricem = mahogany.ToString("C");
            something = 0;
            incorrect = something.ToString("C");

            Console.WriteLine("Pine wood = {0}", pricep);
            Console.WriteLine("Oak wood = {0}", priceo);
            Console.WriteLine("Mahogany wood = {0}", pricem);
            Console.WriteLine("Choose 'P' for pine, 'O' for oak, or 'M' for mahogany.");

            input = Console.ReadLine();
            if (input == "p")
            {
                Console.WriteLine("You've selected pine wood for {0}.",pricep);
            }
            if (input == "o")
            {
                Console.WriteLine("You've selected oak wood for {0}.", priceo);
            }
            if (input == "m")
            {
                Console.WriteLine("You've selected mohagony wood for {0}.", pricem);
            }
            else
            {
                Console.WriteLine(incorrect);
            }
        }
    }
}
