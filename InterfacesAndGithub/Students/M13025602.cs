/* William Voto
 * 11/21/2019
 * Assignment 11
 * Models a student (which is me) and the largest prime number
 * Contemporary Programming  
 * votowd@uc.mail.edu
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M13025602 :Student
    {
        public M13025602(String MNumber) : base(MNumber) { }

        public override long ComputeLargestPrimeFactor(long num)
        {
            long result = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (isPrime(i) && num % i == 0) { result = i; break; }
            }
            return result;
        }
        private Boolean isPrime(long num)
        {
            Boolean answer = true;
            for (long i = 2; i < num /2 ; i++)
            {
                if (num % i == 0)
                {// if the number is 0 it will return false and will return the result 
                 // back to the main method else it'll return as true
                    answer = false; break;
                }

            }
            return answer;
        }
    }
}
