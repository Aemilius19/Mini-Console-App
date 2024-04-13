using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Console_App.Models
{
    internal class Student
    {
        static int _studentid;
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Surname { get; set; }
        public  Student(string name, string surname)
        {
            Id = _studentid++;
            Name = name;
            Surname = surname;
        }
        public void StudentShowInfo()
        {
            Console.WriteLine($"student id- {Id} | student name- {Name} | student surname- {Surname}");
        }
    }
}
