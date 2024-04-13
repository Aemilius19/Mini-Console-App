using Mini_Console_App.Models;
using Mini_Console_App.Helper;
using Mini_Console_App.Extensions;

namespace Mini_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Classroom[] classrooms=new Classroom[0];
            Console.WriteLine("Mini Console App-a xow geldiniz");
            do
            {
                Console.WriteLine("Emeliyati secin");
                Console.WriteLine("1-Classroom yarat");
                Console.WriteLine("2-Student yarat");
                Console.WriteLine("3-Butun telebeleri ekrana cihart");
                Console.WriteLine("4-Secilmiw sinifdeki telebeleri ekrana cihart");
                Console.WriteLine("5-Telebe sil");
                Console.WriteLine("0-exit");
                Console.WriteLine("---------------------------");
                string chooice= Console.ReadLine();
                switch (chooice) 
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("CLassromoun adini daxil edin");
                            string classroomname = Console.ReadLine();
                            if (Helper.Helper.CheckClassroomName(classroomname))
                            {
                                Console.WriteLine("CLassin tipini secin");
                                Console.WriteLine("1-Frontend");
                                Console.WriteLine("2-BackEnd");
                                Console.WriteLine("---------------------------");
                                int classtype = Convert.ToInt32(Console.ReadLine());
                                if (classtype == 1 | classtype == 2)
                                {
                                    Classroom newclass = new Classroom(classroomname, classtype);
                                    Console.WriteLine($"Class yaradildi. Class adi -{newclass.Name}, Class Id-si -{newclass.ClassroomId}, Classin limiti-{newclass.StudentLimitType}");
                                    Array.Resize(ref  classrooms, classrooms.Length+1);
                                    classrooms[classrooms.Length - 1] = newclass;
                                }
                                else { Console.WriteLine("Classin tipini sef secdiz");}
                                Console.WriteLine("---------------------------");
                            }

                        }
                        catch (InvalidNameException ex)
                        {

                            Console.WriteLine(ex.Message);
                            Console.WriteLine("---------------------------");
                        }
                        catch (IndexOutOfRangeException ex) { Console.WriteLine(ex.Message); Console.WriteLine("---------------------------"); }
                        break;
                    case "2":
                        try
                        {
                            if (classrooms.Length!=0)
                            {
                                Console.WriteLine("Student adini daxil edin");
                                string studentname = Console.ReadLine();
                                Console.WriteLine("Student soyadini daxil edin");
                                string studentsurname = Console.ReadLine();
                                if (Helper.Helper.CheckNameSurname(studentname,studentsurname)&&Helper.Helper.CheckWord(studentname,studentsurname))
                                {
                                    Console.WriteLine("Hansi classa elave edek?");
                                    string classname = Console.ReadLine();
                                    foreach (Classroom classroom in classrooms)
                                    {
                                        if (classroom.Name.ToLower()==classname.ToLower())
                                        {
                                            Student newstudent = new Student(studentname, studentsurname);
                                            
                                            if (newstudent.Id<classroom.StudentLimitType)
                                            {
                                                classroom.AddStudent(newstudent);
                                                Console.WriteLine($"Student elave olundu. Id-si :{newstudent.Id}, Adi:{newstudent.Name}, Soyadi : {newstudent.Surname}");
                                                Console.WriteLine($"Elave olundugu class : {classroom.Name}, classin id-si : {classroom.ClassroomId} ");
                                                Console.WriteLine("---------------------------");
                                            }
                                        }
                                        else { continue; }
                                        

                                    }

                                }
                                
                            }
                            else { throw new ClasroomNotFoundException("Claasroom olamadan student yaradila bilmez"); }
                            Console.WriteLine("---------------------------");

                        }
                        catch (ClasroomNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (InvalidNameException ex) { Console.WriteLine(ex.Message); }
                        break;
                    case "3":
                        try
                        {
                            foreach (Classroom classroom in classrooms)
                            {
                                foreach (Student students in classroom.Students)
                                {
                                    Console.WriteLine($"{classroom.Name}\t");
                                    students.StudentShowInfo();
                                }
                            }

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("Classroomu secin (adini daxil edin)");
                            foreach (Classroom classroom in classrooms)
                            {
                                Console.WriteLine($"{classroom.Name}");
                            }
                            string input = Console.ReadLine();
                            foreach (Classroom classroom in classrooms)
                            {
                                
                                if (input.ToLower()==classroom.Name.ToLower())
                                {
                                    foreach (Student student in classroom.Students)
                                    {
                                        student.StudentShowInfo();
                                    }

                                }
                                
                            }

                        }
                        catch (ClasroomNotFoundException ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        catch (InvalidNameException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Silmek istediyiniz studentin id-sini daxil edin");
                            int id=Convert.ToInt32(Console.ReadLine());
                            foreach (Classroom rooms in classrooms)
                            {
                                rooms.DeleteStudent(id);
                                Console.WriteLine("telebe silindi");
                                Console.WriteLine("---------------------------");
                            }

                        }
                        catch (StudentNotFoundException ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "0":
                        Console.WriteLine("Good bye");
                        Console.WriteLine("---------------------------");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Verilmiw emiliyatlardan birini secin!");
                        Console.WriteLine("---------------------------");
                        break;
                }

            } while (exit!=true);
        }
    }
}
