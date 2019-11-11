using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    /// <summary>
    /// Model a student in this class
    /// </summary>
    abstract class Student : IStudent
    {
        private String mMNumber;
        /// <summary>
        /// M Number
        /// </summary>
        /// <param name="MNumber"></param>
        public Student(String MNumber) { mMNumber = MNumber; }
        public String MNumber
        {
            get { return MNumber; }
        }
        public abstract long ComputeLargestPrimeFactor(long num);
    }
}
