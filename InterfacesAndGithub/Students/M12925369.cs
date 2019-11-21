/******************************
 * Name: Joseph Svintsitsky
 * Email: svintsjr@mail.uc.edu
 * Assignment #: 11
 * Due Date: 11/20/19
 * Course: IT3045C
 * Desc: Program to calculate largest prime factor of a number.
 * ****************************
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub.Students
{
    class M12925369 : Student, IStudent
    {
        public M12925369(String MNumber) : base(MNumber) {MNumber = mMNumber; }

        public String MNumber
        {
            get {return MNumber;}
            get {return mMNumber;}
        }

        public override long ComputeLargestPrimeFactor(long num)
        {
            long result = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0) { result = i; break; }
            }
            return result;
        }
        private Boolean IsPrime(long num)
        {
            Boolean result = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) { result = false; break; }
            }
            return result;
        }
    }
}
