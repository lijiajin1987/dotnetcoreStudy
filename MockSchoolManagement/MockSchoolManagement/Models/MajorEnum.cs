using System.ComponentModel.DataAnnotations;

namespace MockSchoolManagement.Models
{
    public enum MajorEnum
    {
        [Display(Name ="未分配")]
        None,
        [Display(Name = "计算机科学")]
        FirstGrade,
        [Display(Name = "电子商务")]
        SecondGrade,
        [Display(Name = "数学")]
        GradeThree,
        [Display(Name = "物流")]
        Fourthgrade,
    }
}
