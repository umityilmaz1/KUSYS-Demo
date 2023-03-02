using AutoMapper;
using KUSYS_Demo.Models.Course;
using KUSYS_Demo.Models.Student;
using Model.Entity;

namespace KUSYS_Demo.AutoMapper.Profiles
{
	public class DefaultProfile : Profile
	{
		public DefaultProfile()
		{
			CreateMap<Student, StudentIndexViewModel>();
			CreateMap<StudentIndexViewModel, Student>();

			CreateMap<Course, CourseViewModel>();
			CreateMap<CourseViewModel, Course>();

			CreateMap<Student, DetailsViewModel>().ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.Courses))
												  .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToString("dd.MM.yyyy")));
		}
	}
}
