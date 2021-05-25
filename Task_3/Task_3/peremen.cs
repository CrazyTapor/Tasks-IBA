using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Worker
    {
        public string name { get; set; }
        public string department { get; set; }
        public int salary { get; set; }
        public override string ToString()
        {
            return $"Ф.И.О: {name} Отдел: {department} Зарплата: {salary}$";
        }

    }
}
