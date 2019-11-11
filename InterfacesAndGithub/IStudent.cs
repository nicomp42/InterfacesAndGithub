using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    /// <summary>
    /// Student Behavior. We program to the interface!
    /// </summary>
    interface IStudent
    {
        /// <summary>
        /// Compute the largest prime factor of a long int
        /// </summary>
        /// <param name="num">The number to factor</param>
        /// <returns>The largest prime factor of num</returns>
        long ComputeLargestPrimeFactor(long num);
    }
}
