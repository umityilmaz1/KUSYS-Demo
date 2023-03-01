using AutoMapper;
using KUSYS_Demo.Models.Course;
using KUSYS_Demo.Models.Student;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.Abstract;

namespace KUSYS_Demo.Controllers
{
    public class CourseController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(IStudentService studentService, ICourseService courseService, IMapper mapper)
        {
            _studentService = studentService;
            _courseService = courseService;
            _mapper = mapper;
        }

        [Route("/Course/GetStudentCourseData/{studentId}")]
        public JsonResult GetStudentCourseData(int studentId)
        {
            var student = _studentService.GetById(studentId);
            var courses = _courseService.GetList(a => a.IsActive);

            var response = new StudentCourseDataViewModel();
            response.TableDatas = _mapper.Map<List<CourseViewModel>>(student.Courses);
            response.DropdownDatas = _mapper.Map<List<CourseViewModel>>(courses.Where(a => !student.Courses.Select(a => a.ID).Contains(a.ID)).ToList());
            response.StudentId = studentId;

            return Json(response);
        }            
    }
}
