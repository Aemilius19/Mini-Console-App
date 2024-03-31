using ConsoleApp4.Models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|=====Welcome=====|");
            bool exit = false;
            Departament departament = new Departament();

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("|===Choose operation===|");
                Console.WriteLine("1-Add Employee");
                Console.WriteLine("2-Watch All Employes");
                Console.WriteLine("0-exit");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Employee neemploye = CreateEmployee();
                        Console.WriteLine("Employee Yaradildi");
                        departament.AddEmployee(neemploye);
                        Console.WriteLine("|================|");
                        break;
                    case "2":
                        Console.WriteLine("|================|");
                        departament.GetAllEmployess();
                        break;
                    case "0":
                        Console.WriteLine("|================|");
                        Console.WriteLine("good bye");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("|================|");
                        Console.WriteLine("Duzgun secim edin");
                        break;
                }

            } while (exit != true);
        }
        public static Employee CreateEmployee()
        {
            Console.WriteLine("employee departament nomresini daxil edin");
            byte DepartamentNo = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("employee id -ni daxil edin");
            byte id = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("employee adini daxil edin");
            string Name = Console.ReadLine();

            Console.WriteLine("employee soyadini daxil edin");
            string Surname = Console.ReadLine();

            Console.WriteLine("employee Age-ni daxil edin");
            byte Age = Convert.ToByte(Console.ReadLine());


            Console.WriteLine("employee Salarysini daxil edin");
            float Salary = Convert.ToSingle(Console.ReadLine());
            Employee newemployee = new Employee(Name,Surname,Age,DepartamentNo,Salary,id);
            return newemployee;
        }

    }
}

