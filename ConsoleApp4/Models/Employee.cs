using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class Employee
    {
        int _id;
        string _name;
        string _surname;
        byte _age;
        double _salary;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0) { _id = value; }
                
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3)
                {
                    _name = value;
                }
                
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length >= 5)
                {
                    _surname = value;
                }
                
            }
        }
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value > 0) { _age = value; }
                
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }

            }
        }

        public Employee(string name, string surname, byte age, byte departamentno, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        public Employee(string name, string surname, byte age, byte departamentno, double salary, int id)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Id = id;
        }

    }
}

