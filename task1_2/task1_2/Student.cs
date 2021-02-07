using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2
{
    class Student
    {
        private string first_name { get; set; }
        private string last_name { get; set; }
        private int age { get; set; }
        private string group { get; set; }
        private string university { get; set; }
        public Student(string n, string m, int a,  string p, string k) { first_name = n; last_name = m; age = a; university = p; group = k;  }
        public void ownPerson()
        {
            Console.WriteLine("STUDENT");
            Console.WriteLine($" Name:{first_name} {last_name} Age:{age} \n University: {university}\n Group:{group}");
            Console.WriteLine("\n");
        }
        public void Mark()
        {
            Console.WriteLine("RATING LIST");
            Marks[] marks = new Marks[5];
            marks[0] = new Marks("Maths", 8);
            marks[1] = new Marks("Physics", 10);
            marks[2] = new Marks("Basics of programming", 8);
            marks[3] = new Marks("Business fundamentals", 10);
            marks[4] = new Marks("Electronic devices", 9);
            marks[0].Passport();
            marks[1].Passport();
            marks[2].Passport();
            marks[3].Passport();
            marks[4].Passport();
            Console.WriteLine("\n");
        }
        public void GetAvgMark()
        { 
            Marks[] marks = new Marks[5];
            marks[0] = new Marks("Maths", 8);
            marks[1] = new Marks("Physics", 10);
            marks[2] = new Marks("Basics of programming", 8);
            marks[3] = new Marks("Business fundamentals", 10);
            marks[4] = new Marks("Electronic devices", 9);
            int sum = 0; double average = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += marks[i].mark;
            }

            average = sum / 5;
            Console.WriteLine($"Average:{average}");
            Console.WriteLine("\n");
        }
        public void ResetAllMarks()
        {
            Marks[] marks = new Marks[5];
            marks[0] = new Marks("Maths", 8);
            marks[1] = new Marks("Physics", 10);
            marks[2] = new Marks("Basics of programming", 8);
            marks[3] = new Marks("Business fundamentals", 10);
            marks[4] = new Marks("Electronic devices", 9);
            for (int i = 0; i < 5; i++)
            {
                marks[i].mark=0;
            }
            marks[0].Passport();
            marks[1].Passport();
            marks[2].Passport();
            marks[3].Passport();
            marks[4].Passport();
            Console.WriteLine("\n");
        }

    }
}

