using Mini_Console_App.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mini_Console_App.Helper
{
    internal static class Helper
    {
        public static bool CheckNameSurname(string name,string surname)
        {
            bool _name=false;
            bool _surname=false;
            if (char.IsUpper(name[0])&&name.Length>=3)
            {
                _name=true;
            }
            else { throw new InvalidNameException($"ad ve soyad boyuk heriften yazilmali : {name}"); }
            if (char.IsUpper(surname[0])&&surname.Length>=3)
            {
                _surname=true;
            }
            else { throw new InvalidNameException($"ad vesoyad boyuk herifden baslamalidi : {surname}"); }
            
            return _name && _surname;
        }
        public static bool CheckWord(string name,string surname)
        {
            bool _word=false;
            if (name.Trim().Split().Length==1&&surname.Trim().Split().Length==1)
            {
                _word=true;   
            }
            else
            {
                throw new InvalidNameException($"Ad ve yaxud soyad iki sozden ibaret ola bilmez :{0}");
                
            }
            return _word;

        }
        public static bool CheckClassroomName(string classroomName)
        {
            bool _classroomName=false;
            if (char.IsUpper(classroomName[0])&&char.IsUpper(classroomName[1])&&char.IsDigit(classroomName[2]) && char.IsDigit(classroomName[3]) && char.IsDigit(classroomName[4]))
            {
                _classroomName=true;
            }
            else
            {
                throw new InvalidNameException($"Classroom adi iki boyuk herifden ve 3 reqamnen ibaret olmalidi");
                Console.WriteLine("---------------------------");
            }
            return _classroomName;
        }
    }
}
