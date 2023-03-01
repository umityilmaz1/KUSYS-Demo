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
            var response = _mapper.Map<List<StudentIndexDto>>(students);
            return View(response);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentIndexDto studentIndexDto)
        {
            var student = _mapper.Map<Student>(studentIndexDto);
            _studentService.Create(student);
            return Redirect("Index");
        }

        [Route("/Student/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);
            var response = _mapper.Map<StudentIndexDto>(student);
            return Json(response);
        }

        [HttpPost]
        public ActionResult Edit(StudentIndexDto studentIndexDto)
        {
            var student = _mapper.Map<Student>(studentIndexDto);
            _studentService.Update(student);
            return Redirect("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
           // _studentService.Delete(id);
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
