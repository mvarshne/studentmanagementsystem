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
    }
}
