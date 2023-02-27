using Model.Base;

namespace Model.Entity
{
    public class Student : BaseEntity
    {
        public Student()
        {
            Courses = new List<Course>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
