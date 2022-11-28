using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole
{
    public class Person
    {
        public Person(string fn, string ln, string pesel)
        {
            FirstName = fn;
            LastName = ln;
            PESEL = pesel;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get;}
    }
}
