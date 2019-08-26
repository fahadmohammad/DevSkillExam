using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Entities
{
    public class StudentCourses
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
