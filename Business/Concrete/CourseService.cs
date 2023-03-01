using Model.Entity;
using Repository.Abstract;
using Service.Abstract;
using System.Linq.Expressions;

namespace Service.Concrete
{
    public class CourseService : ICourseService
    {
        ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public int Create(Course entity)
        {
            return _courseRepository.Create(entity);
        }

        public int Update(Course entity)
        {
            return _courseRepository.Update(entity);
        }

        public int Delete(Course entity)
        {
            return _courseRepository.Delete(entity);
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            return _courseRepository.Get(filter);
        }

        public IQueryable<Course> GetList(Expression<Func<Course, bool>> filter = null)
        {
            return _courseRepository.GetList(filter);
        }

        public Course GetById(int id)
        {
            return _courseRepository.GetById(id);
        }
    }
}
