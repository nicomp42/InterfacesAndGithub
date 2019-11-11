using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class TestStudent : Student {
    
        public TestStudent(String MNumber) : base(MNumber) { }

        public override long ComputeLargestPrimeFactor(long num) {
            long result = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0) { result = i; break; }
            }
            return result;
        }
        private Boolean IsPrime(long num) {
            Boolean result = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) { result = false; break; }
            }
            return result;
        }
    }
}
