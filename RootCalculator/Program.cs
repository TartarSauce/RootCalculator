using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RootCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double error = 0.0001;

            Heron heronCalculator = new Heron(error);
            Validate builtinCalculator = new Validate();

           compareResults(error, builtinCalculator, heronCalculator);

            Console.WriteLine("All Done");
            Console.ReadLine();
        }

        public static void compareResults(double error, InthRt builtinCalculator, InthRt heronCalculator)
        {
            Random rand = new Random();
            int number = rand.Next(0, 10000);
            int numCalculations = 100000;
            int root = rand.Next(2,50);
            int numErrors = 0;

            for (int i = 1; i < numCalculations; i++)
            {
                if (Math.Abs(builtinCalculator.calcNthRoot(number, root) - heronCalculator.calcNthRoot(number, root)) >= error)
                {
                    Console.WriteLine("Error with this number ", number);
                    numErrors++;
                }
                number = rand.Next(0, 100000);
            }
            Console.WriteLine(numErrors);
        }
    }
}
