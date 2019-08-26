using FinalExam.Data.Core.Services;
using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.Model
{
    public class CourseModel
    {
        public ICourseService _courseService;

        public CourseModel()
        {

        }
        public CourseModel(ICourseService courseService)
        {
            this._courseService = courseService;
        }
        public IList<Course> GetCourses()
        {
            return _courseService.GetCourses();
        }
    }
}
