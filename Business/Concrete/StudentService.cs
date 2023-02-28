using Model.Entity;
using Repository.Abstract;
using Service.Abstract;
using System.Linq.Expressions;

namespace Service.Concrete
{
    public class StudentBusiness : IBaseService<Student>
    {
        IStudentRepository _studentRepository;
        public StudentBusiness(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public int Create(Student entity)
        {
            return _studentRepository.Create(entity);
        }

        public int Update(Student entity)
        {
            return _studentRepository.Update(entity);
        }

        public int Delete(Student entity)
        {
            return _studentRepository.Delete(entity);
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            return _studentRepository.Get(filter);
        }

        public IQueryable<Student> GetList(Expression<Func<Student, bool>> filter = null)
        {
            return _studentRepository.GetList(filter);
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
