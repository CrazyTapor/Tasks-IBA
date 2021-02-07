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
        public Student(string n, string m, int a, string p, string k) { first_name = n; last_name = m; age = a; university = p; group = k; }
        public int n = Convert.ToInt32(Console.ReadLine());  //ввод количества оценнок

        Mark[] marks = new Mark[20];
        // персоналные данные о студенте
        public void ownPerson()
        {
            Console.WriteLine("STUDENT");
            Console.WriteLine($" Name:{first_name} {last_name} Age:{age} \n University: {university}\n Group:{group}");
            Console.WriteLine("\n");
        }


        //ввод оценок        
        public void Mark()
        {
            Console.WriteLine("enter ratings:");
            for (int i = 0; i < n; i++)
            {
                marks[i] = new Mark();
                Console.WriteLine($"Mark № {i + 1}:");
                marks[i].mark = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            marks[n] = new Mark();
            marks[0].subject = "Maths";
            marks[1].subject = "Physics";
            marks[2].subject = "Business strategy";
            marks[3].subject = "Electronic devices";
            marks[4].subject = "Microprocessor technology";
            marks[5].subject = "Converting technology";
            Console.Clear();
        }
        //ввывод оценнок и предметов
        public void Mark2()
        {
            Console.WriteLine("RATING LIST");
            for (int i = 0; i < n; i++)
            {
                marks[i].Passport();
            }
            Console.WriteLine("\n");
        }
        //средний балл
        public void GetAvgMark()
        {

            int sum = 0; double average = 0;
            for (int i = 0; i < n; i++)
            {
                sum += marks[i].mark;
            }
            average = sum / n;
            Console.WriteLine($"Average:{average}");
            Console.WriteLine("\n");
        }
        //обнуление всех оценнок
        public void ResetAllMarks()
        {

            for (int i = 0; i < n; i++)
            {
                marks[i] = new Mark();
                marks[i].mark = 0;
            }
            marks[n] = new Mark();
            marks[0].subject = "Maths";
            marks[1].subject = "Physics";
            marks[2].subject = "Business strategy";
            marks[3].subject = "Electronic devices";
            marks[4].subject = "Microprocessor technology";
            marks[5].subject = "Converting technology";
            for (int i = 0; i < n; i++)
            {
                marks[i].Passport();
            }
            Console.WriteLine("\n");
        }

    }
}