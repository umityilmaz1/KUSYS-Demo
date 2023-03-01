using AutoMapper;
using KUSYS_Demo.Models.Student;
using Model.Entity;

namespace KUSYS_Demo.AutoMapper.Profiles
{
	public class DefaultProfile : Profile
	{
		public DefaultProfile()
		{
			CreateMap<Student, StudentIndexDto>();
			CreateMap<StudentIndexDto, Student>();
		}
	}
}
