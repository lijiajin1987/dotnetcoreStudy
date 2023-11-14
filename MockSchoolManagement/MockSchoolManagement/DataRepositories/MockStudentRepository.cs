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
                new Student(){Id=1,Name="张三",Major="计算机科学",Email="zhangsan@qq.com" },
                new Student(){Id=2,Name="李四",Major="物流",Email="lisi@qq.com" },
                new Student(){Id=3,Name="王五",Major="电子商务",Email="wangwu@qq.com" },
                new Student(){Id=4,Name="赵六",Major="会计",Email="zhaoliu@qq.com" },
            };

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
