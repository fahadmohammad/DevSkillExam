using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Data.Core.Model;
using FinalExam.Data.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Web.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class StudentTeacherController : Controller
    {
        private IStudentService _studentService;

        public StudentTeacherController(StudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var studentModel = new StudentModel(_studentService);
            var studentList = studentModel.GetStudents();
            return View(studentList);
        }
    }
}