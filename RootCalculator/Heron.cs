using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootCalculator
{
    class Heron : ISqrRt, ICubeRt, InthRt
    {
        private double errorMargin;

        public Heron(double em)
        {
            this.errorMargin = em;
        }

        // calculate nth root
        public double calcNthRoot(int number, int root)
        {
            double[] quotients = new double[root - 1];

            try
            {
                if (number < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Unable to find root of a non-negative number");
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    Random rand = new Random();
                    double guess = rand.Next(2, 100);

                    quotients[0] = number / guess;
                    for (int i = 1; i < quotients.Length; i++)
                    {
                        quotients[i] = quotients[i-1] / guess;                     
                    }

                    // new guess
                    guess = (guess * (root - 1) + quotients[quotients.Length-1])/ root;

                    while (Math.Abs(number - Math.Pow(guess, root)) > errorMargin)
                    {
                        quotients[0] = number / guess;
                        for (int i = 1; i < quotients.Length; i++)
                        {
                            quotients[i] = quotients[i - 1] / guess;
                        }

                        // new guess
                        guess = (guess * (root - 1) + quotients[quotients.Length - 1]) / root;
 
                    }
                    return guess;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        // calculate cube root
        public double calcCubeRoot(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Unable to find root of a non-negative number");
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    Random rand = new Random();
                    double guess = rand.Next(2,100);
                    double quotient1, quotient2;

                    quotient1 = number / guess;
                    quotient2 = quotient1 / guess;
                    guess = ((guess + guess + quotient2) / 3);
                    
                    while (Math.Abs(number - (guess*guess*guess)) > errorMargin)
                    {
                        double i = (number - (guess * guess * guess));
                        quotient1 = number / guess;
                        quotient2 = quotient1 / guess;
                        guess =((guess + guess + quotient2) / 3);
                    }
                    return (guess + guess + quotient2) / 3;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        // calculate square root
        public double calcRoot(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Unable to find root of a non-negative number");
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    double guess = number / 2;
                    double quotient;

                    quotient = number / guess;
                    while (Math.Abs(number - (quotient * quotient)) > errorMargin)
                    {
                        guess = (guess + quotient) / 2;
                        quotient = number / guess;
                    }
                    return quotient;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
