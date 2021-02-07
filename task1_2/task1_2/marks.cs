using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2
{
    class Marks
    { 
        
        private string subject { get; set; }
        public int mark { get; set; }
        public Marks( string subject , int mark)
        {
            this.subject = subject;
            this.mark = mark;
        }
        public void Passport()
        {
            Console.WriteLine($" subject: {subject} - {mark}");
        }

    }

}

