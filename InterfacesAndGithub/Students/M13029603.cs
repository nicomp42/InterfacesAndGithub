/*
 * Name: Christian Turner
 * Email: turne2cn@mail.uc.edu
 * Assignment #: GitHub Assignment
 * Due Date: 21 November 2019
 * Course: 2198-1_34IT3045C001
 * Description:	Fills out Student based on the Student parent
 * Citations: https://www.mesacc.edu/~scotz47781/mat120/notes/radicals/simplify/images/examples/prime_factorization.html
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M13029603 : Student
    {
        private String mMNumber;

        /// <summary>
        /// M Number
        /// </summary>
        /// <param name="MNumber"></param>
        public M13029603(String MNumber) : base(MNumber)
        { mMNumber = MNumber; }

        public String MNumber
        {
            get { return mMNumber; }
        }

        /// <summary>
        /// Computes the Largest Prime Factor
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public override long ComputeLargestPrimeFactor(long num)
        {
            // declare i to be used in return
            int i;
            for (i = 2; i < num; i++)
            {
                // check if it can be divided (not prime)
                if (num % i == 0)
                {
                    // if not prime, divide num by i
                    num /= i;
                    // minus i incase the next number is also divisible by current
                    i--;
                }
            }

            // return largest prime factor
            return i;
        }
    }
}