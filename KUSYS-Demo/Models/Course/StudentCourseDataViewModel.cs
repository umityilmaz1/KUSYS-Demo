using KUSYS_Demo.Models.Course;

namespace KUSYS_Demo.Models.Student
{
    public class StudentCourseDataViewModel
    {
        public int StudentId { get; set; }
        public List<CourseViewModel> DropdownDatas { get; set; }
        public List<CourseViewModel> TableDatas { get; set; }
    }
}
