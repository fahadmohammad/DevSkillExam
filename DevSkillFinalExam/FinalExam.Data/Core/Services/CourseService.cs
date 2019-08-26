using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalExam.Data.Core.UOW;
using FinalExam.Data.Entities;

namespace FinalExam.Data.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly CourseUnitOfWork _courseUnitOfWork;

        public CourseService(CourseUnitOfWork courseUnitOfWork)
        {
            _courseUnitOfWork = courseUnitOfWork;
        }

        public IList<Course> GetCourses()
        {
            return this._courseUnitOfWork.Courses.GetAll().ToList();
        }
        public void CreateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void EditCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
