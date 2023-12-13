using MockSchoolManagement.Models;
using System.Collections;
using System.Collections.Generic;

namespace MockSchoolManagement.DataRepositories
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();
        Student Add(Student student);
    }
}
