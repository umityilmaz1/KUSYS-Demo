using Model.Base;

namespace Model.Entity
{
    public class Course : BaseEntity
    {
        public Course()
        {
            Students = new List<Student>();
        }

        public string Name { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
