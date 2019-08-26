using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Data.Core.Model;
using FinalExam.Data.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(CourseService courseService)
        {
            this._courseService = courseService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var courseModel = new CourseModel(_courseService);
            var courseList = courseModel.GetCourses();
            return View(courseList);
        }
    }
}