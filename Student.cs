using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2
{
    class Student
    {
        public int Id { get; }
        public string Name;
        public string Surname;
        public int Age;
        public double Point;
        public bool IsExisted;

        public Student(int id)
        {
            Id = id;
            id = 32145;
            id++;
            Console.WriteLine(id++);
        }
        public Student(string name, string surname, double point)
        {
            Name = name;
            Surname = surname;
            Point = point;
           
            if (name == " " || surname == " " || point < 0)
            {
                Console.WriteLine("Daxil edilen melumatlar duzgun deyil!");
            }
            IsExisted = true;
            Console.WriteLine("ID:" + Id++);
        }
        public Student(string name, string surname, int age, double point)
        {
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}, Surname:{Surname}, Point:{Point}");
        }

    }
}
