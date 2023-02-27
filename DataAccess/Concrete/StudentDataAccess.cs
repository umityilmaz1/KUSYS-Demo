using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Model.Entity;

namespace DataAccess.Concrete
{
    public class StudentDataAccess : EFRepositoryBase<Student, KUSYSContext>, ICourseDataAccess
    {             
        
    }
}