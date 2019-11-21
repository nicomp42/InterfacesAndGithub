using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M11234435 : Student
    {
        public M11234435(String mNumber) : base(mNumber)
        {
        }
        public override long ComputeLargestPrimeFactor(long num)
        {
            long LPF = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0)
                {
                    LPF = i;
                    break;
                }
            }
            return LPF;
        }
        private Boolean IsPrime(long num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
