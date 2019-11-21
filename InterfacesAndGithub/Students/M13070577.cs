/*********************************************************************************************
 * Name            - Alexander Spurlock
 * Email Address   - spurloag@mail.uc.com
 * Assignment #    - Student M# Assignemnt
 * Due date        - 11/21/2019
 * Course          - IT3045C (C#)
 * Description     - Program to calculate largest prime factor of a number
 **********************************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M13070577 : Student
    {
        public M13070577(String MNumber) : base(MNumber) { }

        /// <summary>
        /// Calculates the largest prime factor
        /// </summary>
        /// <param name="num"></param>
        /// <returns>the largest prime factor</returns>
        public override long ComputeLargestPrimeFactor(long num)
        {
            // array to store all factors of a given number
            ArrayList factors = getFactorsOfNum(num);

            long largestFactor = 0;

            // go through each number in 'factors' array
            foreach  (long factor in factors)
            {
                // check if the factor is prime and larger than current largest prime factor
                if(isPrime(factor) && factor > largestFactor)
                {
                    // reassign the last eligible factor to 'largestFactor'
                    largestFactor = factor;
                }

            }

            // return the largest prime factor
            return largestFactor;

        }
        /// <summary>
        /// Checks if a number is prime or not
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True if prime, False if not prime.</returns>
        public bool isPrime(long num)
        {

            if (num <= 1)
            {
                return false;
            }

            for (long i = 2; i <= ((long)Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        /// <summary>
        ///  Collects all factors of a given number
        /// </summary>
        /// <param name="num"></param>
        /// <returns>An ArrayList of all factors from a given number.</returns>
        public ArrayList getFactorsOfNum(long num)
        {
            ArrayList factors = new ArrayList();
            for (long i = 1; i <= num; i++)
            {

                if (num % i == 0)
                {
                    factors.Add(i);
                }

            }
            return factors;
        }
    }
}
