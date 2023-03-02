using AutoMapper;
using KUSYS_Demo.Models.Student;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.Abstract;

namespace KUSYS_Demo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, ICourseService courseService, IMapper mapper)
        {
            _studentService = studentService;
            _courseService = courseService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var students = _studentService.GetList(a => a.IsActive);
            var response = _mapper.Map<List<StudentIndexViewModel>>(students);
            return View(response);
        }

        public ActionResult Create()
        {
            var viewModel = new StudentIndexViewModel();
            return View("CreateOrUpdate", viewModel);
        }

        [Route("/Student/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);
            var viewModel = _mapper.Map<StudentIndexViewModel>(student);
            return View("CreateOrUpdate", viewModel);
        }

        [HttpPost]
        public ActionResult SaveOrUpdate(StudentIndexViewModel studentIndexDto)
        {
            if (studentIndexDto.ID == 0)
            {
                var student = _mapper.Map<Student>(studentIndexDto);
                _studentService.Create(student);
            }
            else
            {
                var student = _studentService.GetById(studentIndexDto.ID);
                var updatedStudent = _mapper.Map(studentIndexDto, student);
                _studentService.Update(updatedStudent);
            }

            return Redirect("Index");
        }

        [Route("/Student/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            var student = _studentService.GetById(id);
            _studentService.Delete(student);
            return RedirectToAction("Index");
        }

        [Route("/Student/MatchCourseToStudent/{studentId}/{courseId}")]
        [HttpPost]
        public JsonResult MatchCourseToStudent(int studentId, int courseId)
        {
            var course = _courseService.GetById(courseId);
            var student = _studentService.GetById(studentId);

            if (student != null && course != null)
            {
                student.Courses.Add(course);
                _studentService.Update(student);
                return Json(true);
            }

            return Json(false);
        }

        [Route("/Student/RemoveCourseFromStudent/{studentId}/{courseId}")]
        [HttpPost]
        public JsonResult RemoveCourseFromStudent(int studentId, int courseId)
        {
            var course = _courseService.GetById(courseId);
            var student = _studentService.GetById(studentId);

            if (student != null && course != null)
            {
                student.Courses.Remove(course);
                _studentService.Update(student);
                return Json(true);
            }

            return Json(false);
        }

        [Route("/Student/Details/{studentId}")]
        [HttpGet]
        public JsonResult Details(int studentId)
        {
            var student = _studentService.GetById(studentId);
            var response = _mapper.Map<DetailsViewModel>(student);
            return Json(response);
        }
    }
}
