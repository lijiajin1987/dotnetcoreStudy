using System.ComponentModel.DataAnnotations;

namespace MockSchoolManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name ="名字")]
        [Required(ErrorMessage ="请输入名字，它不能为空")]
        public string Name { get; set; }
        [Display(Name = "主修科目")]
        public MajorEnum Major { get; set; }
        [Display(Name = "电子邮箱")]
        [Required(ErrorMessage ="请输入电子邮箱地址，它不能为空。")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage ="邮箱格式不正确")]
        public string Email { get; set; }
    }
}
