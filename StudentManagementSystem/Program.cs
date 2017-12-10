using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the student management system..");

            Console.WriteLine("how many students do you want to add, please add at least one..thanks..?");

            int numberOfStudents = int.Parse(Console.ReadLine());

            Student[] students = new Student[numberOfStudents];

            int stIndex = 1;

            while (stIndex <= numberOfStudents)
            {
                Console.WriteLine($"collecting details for student {stIndex}");
                Console.WriteLine("Name?");
                string name = Console.ReadLine();
                Console.WriteLine("State?");
                string state = Console.ReadLine();

                students[stIndex - 1] = StudentsFactory.Instance.AddNewStudent(name, state);
                stIndex++;
            }

            Console.WriteLine();
            Console.WriteLine("here are the details of students entered..");

            foreach(var student in students)
            {
                Console.WriteLine(StudentUtil.GetStudentDetailsInStringFormat(student));
            }

            Console.ReadLine();
        }
    }
}
