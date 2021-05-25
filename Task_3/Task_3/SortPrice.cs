using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    //сортировка по затраченной энергии за месяц по убыванию
     class SortSalary : Worker, IComparer<Worker>
    {

        public int Compare(Worker x, Worker y)
        {
            if (x.salary > y.salary)
                return -1;
            else if (x.salary < y.salary)
                return 1;
            else
                return 0;
        }
        
    }
}

