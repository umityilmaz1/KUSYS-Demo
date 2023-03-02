using KUSYS_Demo.Models.Course;

namespace KUSYS_Demo.Models.Student
{
    public class DetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public List<CourseViewModel> Courses { get; set; }
    }
}
