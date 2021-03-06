﻿using System;
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
    }
}
