/*
 * Julie Greger
 * gregerjl@mail.uc.edu
 * IT3045 Contemporary Programming
 * Assignment - code studentID class
 * Due Date - November 13, 2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M12847946 : Student
    {
             

        public M12847946(String MNumber) :base(MNumber)
        {
           
        }
        public override long ComputeLargestPrimeFactor(long num)
        {
              
            for (long i = (long)Math.Sqrt(num); i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0)
                {
                    return i;
                }
            }
            throw new Exception("Your student number has no prime factors for some reason.");
        }
        private Boolean IsPrime(long num)
        {
            // One is not prime.
            if (num == 1)
            {
                return false;
            }
            // Two is prime.
            if (num == 2)
            {
                return true;
            }
            // Search for numbers evenly divided by two.
            if (num % 2 == 0)
            {
                return false;
            }
            // Search for odd numbers for factors of num.
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}

