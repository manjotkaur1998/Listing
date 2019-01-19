using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732136
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.8, 20);

            StudentInformation _john = new StudentInformation("john", 3.8, 20);

            StudentInformation _Mark = new StudentInformation("Mark", 3.8, 20);

            StudentInformation _Steve = new StudentInformation("Steve", 3.8, 20);

            StudentInformation _Cindy = new StudentInformation("Cindy", 3.8, 20);

            Console.ReadLine();

        }
    }

    }

    class StudentInformation

    {

        public string name;



        public double GPA;

        public int attendence;

        public StudentInformation(string aName, double aGPA, int dAttendence)

        {

            name = aName;

            GPA = aGPA;

            attendence = dAttendence;
        }

    }

         
    
    

