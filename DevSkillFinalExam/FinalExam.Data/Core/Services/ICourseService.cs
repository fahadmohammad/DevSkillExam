using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.Services
{
    public interface ICourseService
    {
        void CreateCourse(Course course);
        Course GetCourse(Guid id);
        IList<Course> GetCourses();
        void EditCourse(Course course);
        void DeleteCourse(Course course);
    }
}
