using Mini_Console_App.Enum;
using Mini_Console_App.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Console_App.Models
{
    internal class Classroom
    {
        static int _classid;
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public Student[] Students;
        int _studentlimit;
        public int StudentLimitType 
        {
            get { return _studentlimit; }
            set 
            {
                if (value==1) 
                {
                    _studentlimit = Convert.ToInt32(RoomTypeEnum.Frontend);
                }
                else if(value==2) 
                {
                    _studentlimit= Convert.ToInt32(RoomTypeEnum.Backend);

                }
            } 
        }
        public Classroom(string name,int limitmode)
        {
            Students = new Student[0];
            ClassroomId = _classid++;
            Name = name;
            StudentLimitType = limitmode;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length-1]= student;
        }
        public Student FindStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;                   
                }
            }
            return null;
        }

        public void DeleteStudent(int id)
        {
            Student[] NewStudents=new Student[0];
            foreach (Student student in Students)
            {
                
                if (student.Id== id)
                {
                    break;
                }
                else if (student.Id!=id)
                {
                    NewStudents.Append(student);
                    
                }
                else { throw new StudentNotFoundException("bu Idli student tapilmadi"); }
            }
            Students = NewStudents;
        }

    }
}
