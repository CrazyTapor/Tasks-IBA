using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Develop custom class Employee containing personal information and salary value.
//Make possible to sort a list of Employees by salary or by personal info.
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int selector;
            List<Worker> listOfWorkers = new List<Worker>()
            {
                new Worker() { name = "Nalivalkin A.V.", department = ".Net", salary = 150 },
                new Worker() { name = "Rebenok D.V.", department = "Data engineering", salary = 200 },
                new Worker() { name = "Koghemyakin V.A", department = "Data engineering", salary = 210 },
                new Worker() { name = "Orlov Y.", department = "Android Technologies", salary = 300 },
                new Worker() { name = "Proskyrakov M.", department = "Web development", salary = 700 },
            };
            foreach (Worker worker in listOfWorkers)
            {
                Console.WriteLine(worker);
            }
            do
            {
                Console.WriteLine("Сортировка по зарплате нажмите 1");
                Console.WriteLine("Сортировка по имени нажмите 2");
                Console.WriteLine("Выход из программы нажмите 2");
                selector = int.Parse(Console.ReadLine());
                switch (selector)
                {
                    case 1:
                        Console.Clear();
                        listOfWorkers.Sort(new SortSalary());
                        foreach (Worker aPart in listOfWorkers)
                        {
                            Console.WriteLine(aPart);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        listOfWorkers.Sort(new SortName());
                        foreach (Worker aPart in listOfWorkers)
                        {
                            Console.WriteLine(aPart);
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                }
               
            } while (selector != 3);
        Console.ReadKey();
        }
    }
}