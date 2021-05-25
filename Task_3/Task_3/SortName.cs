using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class SortName : Worker , IComparer<Worker>
    { 
    public int Compare(Worker x, Worker y)
    {
        if (x.name == null && y.name == null) return 0;
        else if (x.name == null) return -1;
        else if (y.name == null) return 1;
        else return x.name.CompareTo(y.name);
    }

}
}
