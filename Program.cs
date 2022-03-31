using System;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Elnara", "Vahabova", 19, 95);
            student.ShowInfo(); 
            Console.WriteLine(student.Id);

        }
    }
}
