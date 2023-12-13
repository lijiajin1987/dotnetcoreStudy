using MockSchoolManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace MockSchoolManagement.DataRepositories
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;
        public MockStudentRepository() 
        {
            _studentList = new List<Student>()
            {
                new Student(){Id=1,Name="张三",Major=MajorEnum.SecondGrade,Email="zhangsan@qq.com" },
                new Student(){Id=2,Name="李四",Major=MajorEnum.Fourthgrade,Email="lisi@qq.com" },
                new Student(){Id=3,Name="王五",Major=MajorEnum.FirstGrade,Email="wangwu@qq.com" },
                new Student(){Id=4,Name="赵六",Major=MajorEnum.GradeThree,Email="zhaoliu@qq.com" },
            };

        }

        public Student Add(Student student)
        {
            student.Id = _studentList.Max(s => s.Id) + 1;

            _studentList.Add(student);
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(o=>o.Id==id);
        }
    }
}
