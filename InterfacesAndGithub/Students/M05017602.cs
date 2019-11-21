using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M05017602 : Student
    {
        public M05017602(String mNumber) : base(mNumber) { } //Call the base class constructorthat holds mNumber value

        //retusn longest prime of a given number
        public override long ComputeLargestPrimeFactor(long num)
        {
            long lp = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0) { lp = i; break; }
            }
            return lp;
        }
        private Boolean IsPrime(long num)
        {
            Boolean result = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
