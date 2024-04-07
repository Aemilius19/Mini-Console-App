using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Managment.Models
{
    internal class Croup
    {
        Student[] students = new Student[0];
        int _studentlimit;
        public string GroupNo { get; set; }
        public Croup(int studentlimit, string groupno)
        {

            StudentLimit = studentlimit;
            GroupNo = groupno;
        }
        public Croup()
        {
            
        }
        public Croup(int studentlimit)
        {
            StudentLimit=studentlimit;
        }
        public int StudentLimit
        {
            get { return _studentlimit; }
            set
            {
                if (value > 5 && value < 18)
                {
                    _studentlimit = value;
                }
            }
        }
        public bool CheckGroupNo(string groupno)
        {
            bool condition = false;
            if (char.IsUpper(GroupNo[0]) && char.IsUpper(GroupNo[1]) && char.IsDigit(GroupNo[2]) && char.IsDigit(GroupNo[3]) && char.IsDigit(GroupNo[4]))
            {
                condition = true;
                return condition;
            }
            return condition;
        }
        public void AddStudent(Student student)
        {
            if (students.Length <= StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
                Console.WriteLine($"Student elave olundu , student-in id si -{student.ID}");
            }
            else if (students.Length > StudentLimit)
            {
                Console.WriteLine("Limiti kecdiz , student elave olunmadi");
            }
        }
        public void GetStudent(int id)
        {
            bool exception = false;
            foreach (var student in students)
            {
                if (student.ID == id)
                {
                    student.ShowInfo();
                    exception = true;
                }
            }
            if (exception!=true) { Console.WriteLine("Student tapilmadi"); }
        }

        public void GetAllStudent()
        {
           foreach (var student in students)
            {
                student.ShowInfo();
            }
        }
    }
}

