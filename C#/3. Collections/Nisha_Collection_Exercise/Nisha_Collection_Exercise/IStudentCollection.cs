using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_Collection_Exercise
{
    internal interface IStudentCollection
    {
        void AddStudent(Student student);
        void RemoveStudent(string studentID);
        void GetStudent(string studentID);
        void ListAllStudents();

    }
}
