using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class StudentsFactory
    {
        private static StudentsFactory _instance = new StudentsFactory();
        private int _id = 0;

        private StudentsFactory()
        {

        }

        public static StudentsFactory Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new StudentsFactory();
                }
                return _instance;
            }
        }

        public Student AddNewStudent(string name, string state)
        {
            _id++;
            return new Student(_id, name, state);
        }

    }
}
