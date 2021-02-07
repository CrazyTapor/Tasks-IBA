using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Develop a custom class Student containing personal information and array of Marks.
Mark is a custom class containing name of a subject and its mark. Student class also
has GetAvgMark(returning average of all marks) and ResetAllMarks(making all student’s marks equal to zero)
methods, which you need to implement.*/
namespace task1_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Student Andrei = new Student("Andrei" , "Nalivalkin" , 19 , "Gstu name P.O. Suhoi", "PM-31" );
            Andrei.ownPerson();
            Andrei.Mark();
            Andrei.GetAvgMark();
            Andrei.ResetAllMarks();
            Console.ReadKey();
        }

    }
}
