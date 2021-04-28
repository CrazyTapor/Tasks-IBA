using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string group { get; set; }
        public string university { get; set; }
        public int n = Convert.ToInt32(Console.ReadLine());  //ввод количества оценнок

        Mark[] marks = new Mark[20];
        // персоналные данные о студенте
        public void OwnPerson(string name, out string firstNames, out string lastName, ref int age, ref string university, ref string group)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
            age = 20; university = "Gstu of sohoi"; group = "PM-31";
            Console.WriteLine("STUDENT");
            Console.WriteLine($" Name: {firstNames} {lastName} Age:{age} \n University: {university}\n Group:{group}");
            Console.WriteLine("\n");
        }
        //ввод оценок        
        public void InputMark()
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
        public void OutputMark()
        {
            Console.WriteLine("RATING LIST");
            for (int i = 0; i < n; i++)
            {
                marks[i].Passport();
            }
            Console.WriteLine("\n");
        }
        //средний балл
        public int GetAvgMark(params int[] Mark)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += marks[i].mark;
            return sum / n;
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