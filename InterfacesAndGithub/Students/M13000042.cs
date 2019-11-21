/*
 * Isaiah Dicristoforo
 * dicrisif@mail.uc.edu
 * Interfaces and Git Hub Assignment
 *
 * Contemporary Programming
 * Fall 2019
 * Professor Bill Nicholson
 *
 * Due: 11/21/2019
 *
 * Description: Here I implement the class that represents my MNumber, and derives from the student class.
 * I called the base class constructor, and implemented the abstract method that calculated the greatest prime
 * factor of a number.
 *
 * Sources:
 *
 * This program was designed by Professor Bill Nicholson, and will be contributed to by his students.
 * I use the IsPrime method I created during my midterm exam.
 *
 */
using System;

namespace InterfacesAndGithub
{
    /// <summary>
    /// Models a student with the M number listed below.  In this case, the # belongs to me, Isaiah Dicristoforo.
    /// </summary>
    class M13000042 : Student
    {
        public M13000042(String mNumber) : base(mNumber) { } //Calling the base class constructor which stores the MNumber of the student.

        /// <summary>
        /// Computes the largest prime factor.
        /// </summary>
        /// <param name="num">The number to find the largest prime factor of</param>
        /// <returns>The largest prime factor of the given number</returns>
        public override long ComputeLargestPrimeFactor(long num)
        {
            long largestPrimeFactor = -1;

            for (long i = (num - 1); i > 0; i--) //Start at num-1 and work down to zero.
            {
                if (IsPrime(i) && num % i == 0) //Checking to see if our current number, i, is both prime and a factor of our argument.
                {
                    largestPrimeFactor = i;  
                    return largestPrimeFactor;
                }

            }

            return largestPrimeFactor;  
        }

        /// <summary>
        /// Computes whether a number is prime. I created this method during my midterm.
        /// </summary>
        /// <param name="num">The number to check for primality</param>
        /// <returns>True if the number is prime, false otherwise</returns>
        private bool IsPrime(long num) //I created this method during my midterm.
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

