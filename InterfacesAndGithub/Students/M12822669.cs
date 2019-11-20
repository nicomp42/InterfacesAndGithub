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
