using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M13000042 : Student
    {
        public M13000042(String name) : base(name) { }
       
        /// <summary>
        /// Computes the largest prime factor.
        /// </summary>
        /// <param name="num">The number to find the largest prime factor of</param>
        /// <returns>The largest prime factor of the given number</returns>
        public override long ComputeLargestPrimeFactor(long num)
        {
            long largestPrimeFactor = -1;

           for(long i = (num - 1); i > 0; i--)
            {
                if(IsPrime(i) &&  i % 2 == 0)
                {
                    largestPrimeFactor = i;
                    break;
                }
            }

            return largestPrimeFactor;
        }

        /// <summary>
        /// Computes whether a number is prime.
        /// </summary>
        /// <param name="num">The number to check for primality</param>
        /// <returns>True if the number is prime, false otherwise</returns>

        private bool IsPrime(long num)
        {
            bool isPrime = true;  //Initially set to true.  Will be changed as we test the number.

            if (num == 2)
            {
                isPrime = true;

            }
            else if (num == 1 || num == 0 || num % 2 == 0) //A few edge cases
            {
                isPrime = false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(num); i++) //Loop to test if the possible prime has factors.
                {

                    if (num % i == 0) //If the number has a factor, the number is not prime.
                    {
                        isPrime = false;
                        break;
                    }

                }
            }

            return isPrime; //Return whether or not the number is prime.
        }
    }
}
