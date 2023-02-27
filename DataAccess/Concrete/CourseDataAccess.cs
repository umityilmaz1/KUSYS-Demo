using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Model.Entity;

namespace DataAccess.Concrete
{
    public class CourseDataAccess : EFRepositoryBase<Course, KUSYSContext>, ICourseDataAccess
    {             
        
    }
}