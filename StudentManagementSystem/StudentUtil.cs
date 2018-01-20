using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public static class StudentUtil
    {
        public static string GetStudentDetailsInStringFormat(Student st)
        {
            return string.Format($"Student Id: {st.Id}, Name: {st.Name}, and State: {st.State}");
        }

        public static Student[] RemoveStudent(Student[] students, int stid)
        {
            List<Student> studentList = new List<Student>(students);
            int indexOfStudentToBeRemoved = -1;
            foreach (var student in studentList)
            {
                if (student.Id == stid)
                {
                    indexOfStudentToBeRemoved = studentList.IndexOf(student);
                    break;
                }
            }
            if (indexOfStudentToBeRemoved != -1)
            {
                studentList.RemoveAt(indexOfStudentToBeRemoved);
            }
            return studentList.ToArray();
        }

        public static void UpdateName(Student[] students, int sid, string newName)
        {
            Console.WriteLine("Updating Name");
            foreach(var st in students)
            {
                if(st.Id == sid)
                {
                    st.Name = newName;
                }
            }
        }

        public static void UpdateState(Student[] students, int sid, string state)
        {
            Console.WriteLine("Updating State");
            foreach (var st in students)
            {
                if (st.Id == sid)
                {
                    st.State = state;
                }
            }

        }

        public static void SortByName(Student[] students)
        {
            Console.WriteLine("sort by name method welcomes you");
        }

        public static void SortByState(Student[] students)
        {
            //empty method
        }

        public static void RemoveAllByName(Student[] students, string name)
        {
            Console.WriteLine("this is a remove all by name method");

            Console.WriteLine("remove all by name is modified by support 1.0");

            Console.WriteLine("line 1 added by remove all by name in support 1.0");
        }
    }
}
