using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Managment.Models
{
    internal class Student
    {
        static int _id;
        public int ID { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname,double point)
        {
            Fullname = fullname;
            Point = point;
            ID =++_id;
        }

        public void ShowInfo()
        {
            Console.WriteLine( $"Fullname - {Fullname} | Point- {Point} | Id- {ID}");
        }

    }
}
