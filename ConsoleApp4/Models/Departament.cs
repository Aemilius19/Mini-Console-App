using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class Departament
    {
        Employee[] _employees;
        byte _departamentno;
        public byte DepartamentNo
        {
            get { return _departamentno; }
            set
            {
                if (value != null) { _departamentno = value; }
                else { Console.WriteLine("Departament nomresi bow olamaz"); }
            }
        }
        string _departamentname;
        public string DepartamentName
        {
            get { return _departamentname; }
            set { _departamentname = value; }
        }
        Employee[] employees { get { return _employees; } set { _employees = value; } }
        public Departament()
        {
            employees = new Employee[0];
        }
        public Departament(string departamentname, byte departamentno)
        {
            employees = new Employee[0];
            DepartamentName = departamentname;
            DepartamentNo = departamentno;
        }
        public void AddEmployee(Employee employee)
        {
            Employee[] newemployee = new Employee[employees.Length + 1];
            for (int i = 0; i < employees.Length; i++)
            {
                newemployee[i] = employees[i];
            }
            newemployee[newemployee.Length-1] = employee;
            employees = newemployee;
 
        }
        public void ShowEmployeeInfo(int id)
        {
            foreach (var employee in employees)
            {
                if (employee.Id == id)
                {
                    Console.WriteLine($"Name-{employee.Name} || Surname- {employee.Surname} || Age - {employee.Age} || Departament № - {DepartamentNo} || Salary - {employee.Salary} ");
                    Console.WriteLine("\n|===========================|");
                }
                else { Console.WriteLine("Isci tapilmadi"); }
            }
        }

        public string GetAllEmployess()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($" Employee id -{employee.Id}|| Name-{employee.Name} || Surname- {employee.Surname} || Age - {employee.Age} || Salary-{employee.Salary }\n");
            }
            return "";
        }
    }
}

