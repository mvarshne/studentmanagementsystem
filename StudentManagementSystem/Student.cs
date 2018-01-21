using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public Student(int id, string name, string state)
        {
            this.Id = id;
            this.Name = name;
            this.State = state;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + ", Name: " + this.Name + ", State:" + this.State;
        }
    }
}
