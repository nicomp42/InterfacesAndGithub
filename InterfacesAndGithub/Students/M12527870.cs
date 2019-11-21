using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M12527870 : Student
    {
        public M12527870(String MNumber) : base(MNumber) { }
        public override long ComputeLargestPrimeFactor(long num)
        {
            long status = 1;
            for (long i= num / 2; i >= 1; i--)
            {
                if (isPrime(i) && num % i == 0)
                { status = i; break; }
            }
            return status;
        }
        private bool isPrime(long num)
        {
            bool status = true;
            long limit = (long)Math.Sqrt(num);
            for (int i = 2; i <= limit; i++)
            {
                if (num % i == 0)
                {
                    status = false;
                    break;
                }
            }
            return status;
        }
    }
}
