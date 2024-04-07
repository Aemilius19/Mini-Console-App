using Class_Managment.Models;
using System.Text.RegularExpressions;


namespace Class_Managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Console.WriteLine("|====Welcome====|");
            Console.WriteLine("Type Student Fullname");
            string userfullname= Console.ReadLine();
            Console.WriteLine("Type Student Point");
            double userpoint=Convert.ToDouble(Console.ReadLine());
            Student userstudent= new Student(userfullname,userpoint);
            do
            {
                Console.WriteLine("|====Choose operation====|");
                Console.WriteLine("1-Show info");
                Console.WriteLine("2-Create new group");
                Console.WriteLine("3-Exit");
                string userinput= Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("|====Your student info====|");
                        userstudent.ShowInfo();
                        
                        break;
                    case "2":
                        Console.WriteLine("type student limit");
                        int userlimit= Convert.ToInt32(Console.ReadLine());
                        bool submenu= false;
                        Croup chechgroup;
                        if (userlimit > 5 && userlimit < 18)
                        {
                            chechgroup = new Croup(userlimit);
                        }
                        else { Console.WriteLine("Limiti duzgun daxil edin\np.s Limit 5 den yuxari 18 den az olmalidi");break; }
                        Console.WriteLine("type Group No");
                        string usergroupno = Console.ReadLine();
                        chechgroup= new Croup(userlimit,usergroupno);
                        Croup usergroup;
                        if (chechgroup.CheckGroupNo(usergroupno))
                        {
                            usergroup = new Croup(userlimit,usergroupno);
                        }
                        else { Console.WriteLine("Group codunu duzgun daxil edin \n p.s:baslangicda iki boyuk herif,ve 3 reqem"); break; }
                        usergroup.AddStudent(userstudent);
                        Console.WriteLine("|==========|");
                        Console.WriteLine("Group created successfully");
                        do
                        {
                            Console.WriteLine("|==========|");                           
                            Console.WriteLine("Choose operation");
                            Console.WriteLine("1-Show All students");
                            Console.WriteLine("2-Get student by Id");
                            Console.WriteLine("3-Add Student");
                            Console.WriteLine("0-Exit");
                            string submenuchoice= Console.ReadLine();
                            switch (submenuchoice)
                            {
                                case "1":
                                    Console.WriteLine("|====Your group information====|");
                                    usergroup.GetAllStudent();
                                    
                                    break;
                                case "2":
                                    Console.WriteLine("Enter id for searching student");
                                    int userid= Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("|==========|");
                                    Console.WriteLine("|=====Student information=====|");
                                    usergroup.GetStudent(userid);
                                    
                                    break;
                                case "3":
                                    Console.WriteLine("Type Student Fullname");
                                    string usersubfullname = Console.ReadLine();
                                    Console.WriteLine("Type Student Point");
                                    double usersubpoint = Convert.ToDouble(Console.ReadLine());
                                    Student usersubstudent = new Student(usersubfullname, usersubpoint);
                                    if (usersubstudent.ID<usergroup.StudentLimit)
                                    {
                                        usergroup.AddStudent(usersubstudent);
                                    }
                                    else { Console.WriteLine("Limiti kecdiz, student elave olunmadi"); }     
                                    break;
                                case "0":
                                    Console.WriteLine("|====Good Bye====|");
                                    submenu = true;
                                    break;


                            }

                        } while (submenu != true);
                        
                        break;
                    case "3":
                        exit=true;
                        break;

                    default:
                        Console.WriteLine("Choose the right operation");
                        break;
                }
            } while (exit != true); ;
        }
    }
}
