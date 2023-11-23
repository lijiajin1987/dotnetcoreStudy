namespace MockSchoolManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MajorEnum Major { get; set; }
        public string Email { get; set; }
    }
}
