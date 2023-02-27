using Core.DataAccess.EntityFramework;
using Repository.Abstract;
using Repository.Context;
using Model.Entity;

namespace Repository.Concrete
{
    public class CourseRepository : EFRepositoryBase<Course, KUSYSContext>, ICourseRepository
    {             
        
    }
}