/*******************************************************************
 * Name: Matthew Willison
 * Email: willi6m7@mail.uc.edu
 * Assignment #: 11
 * Due Date: 11/20/2019
 * Course: IT3045C
 * Description: This program introduces Github into Visual Studio as well as tests a given number for the highest prime factor.
 * Citations: Isaiah Dicristoforo helped me figure out what to do with pull requests and making commits on Github.
 * Anything else:
 *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M12822669 : Student
    {

        public M12822669(String MNumber) : base(MNumber) { }

        /// <summary>
        /// Computes the largest prime factor of a given number.
        /// </summary>
        /// <param name="num">The given number.</param>
        /// <returns>A long.</returns>
        public override long ComputeLargestPrimeFactor(long num)
        {
            long answer = 0;
            for (long y = num / 2; y > 1; y--)
            {
                if (num % y == 0 && IsPrime(y) == true)
                {

                    answer = y;
                    break;
                }
            }
            return answer;
        }

        /// <summary>
        /// Method that checks a given number for primeness. Reused code from earlier assignments.
        /// </summary>
        /// <param name="num">The number being tested for primeness.</param>
        /// <returns>A boolean</returns>
        public bool IsPrime(long num)
        {
            bool primeness = true;
            for (int x = 2; x < num; x++)
            {
                if (num % x == 0)
                {
                    primeness = false;
                    break;
                }
            }
            return primeness;
        }
    }
}
