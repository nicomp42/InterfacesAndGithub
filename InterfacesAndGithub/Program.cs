using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> myStudents = new List<Student>();
            Student testStudent = new TestStudent("M02635915");
            myStudents.Add(testStudent);
            InitializeStudents(myStudents);
            int passCount = 0;
            int failCount = 0;
            foreach (Student student in myStudents) {
                long MNumber;
                long largestPrimeFactor;
                try {
                    MNumber = System.Convert.ToInt64(student.MNumber.Substring(1));
                    largestPrimeFactor = testStudent.ComputeLargestPrimeFactor(MNumber);
                    if (student.ComputeLargestPrimeFactor(MNumber) == largestPrimeFactor) {
                        passCount++;
                        Console.WriteLine("Test passed for " + student.MNumber);
                    }
                    else {
                        failCount++;
                        Console.WriteLine("Test FAILED for " + student.MNumber);
                    }
                } catch (Exception ex) {
                    failCount++;
                    Console.WriteLine("Exception thrown and Test failed for " + student.MNumber + " (" + ex.Message + ")");
                }
            }
            Console.WriteLine("Pass count = " + passCount + ", fail count = " + failCount);
        }
        private static void InitializeStudents(List<Student> students) {
/*          try {students.Add(new M05017602("M05017602")); } catch (Exception ex) { Console.WriteLine(ex.Message);}
            try {students.Add(new M10839619("M10839619")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M11234435("M11234435")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12193022("M12193022")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12299513("M12299513")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12527870("M12527870")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12537980("M12537980")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12685430("M12685430")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12685430("M12685430")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12822669("M12822669")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M12847946("M12847946")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M13000042("M13000042")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M13025602("M13025602")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M13029603("M13029603")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M13070577("M13070577")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try {students.Add(new M13089614("M13089614")); } catch (Exception ex) { Console.WriteLine(ex.Message); }
*/        }
    }
}
