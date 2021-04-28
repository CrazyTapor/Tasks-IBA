using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string firstName, lastName, university = null, group = null;
            int age = 0;
            Console.WriteLine("number of ratings:");
            Student Andrei = new Student();
            Console.Clear();
            Andrei.InputMark();
            Andrei.OwnPerson("Andrei Nalivalkin", out firstName, out lastName, ref age, ref university, ref group);
            Andrei.OutputMark();
            int Average = Andrei.GetAvgMark();
            Console.WriteLine($"Average score:{Average}");
            Andrei.ResetAllMarks();
            Console.ReadKey();
        }
    }
}



