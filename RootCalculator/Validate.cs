using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootCalculator
{
    class Validate : ISqrRt, ICubeRt, InthRt
    {
        public double calcNthRoot(int number, int root)
        {
            try
            {
                if (number < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Unable to find root of a non-negative number");
                }
                else
                {
                    return Math.Pow(number, 1.0 / root);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                return -1;
            }

        }

        public double calcRoot(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Unable to find root of a non-negative number");
                }
                else
                {
                    return Math.Sqrt(number);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                return -1;
            }
        }

        public double calcCubeRoot(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Unable to find root of a non-negative number");
                }
                else
                {
                    return Math.Pow(number, 1.0 / 3.0);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                return -1;
            }
        }
    }
}
