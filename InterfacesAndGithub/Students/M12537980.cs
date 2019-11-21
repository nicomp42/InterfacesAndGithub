/*Derek Whitfield
 * whitfidr@mail.uc.edu
 * November 12, 2019
 * IT3045C
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M12537980 : Student
    {
        private string mMNumber;


        public M12537980(string MNumber):base(MNumber)
        {
            mMNumber = MNumber;
        }
        public string MNumber
        {
            get { return mMNumber; }
        }
        public override long ComputeLargestPrimeFactor(long num)
        {

            long k = 2;
            while (k * k <= num)
            {
                if (num % k == 0)
                {
                    num /= k;
                }
                else
                {
                    ++k;
                }
            }

            return num;
        }
       


    }
}
