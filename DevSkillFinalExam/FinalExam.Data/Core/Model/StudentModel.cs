using FinalExam.Data.Core.Services;
using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.Model
{
    public class StudentModel
    {
        public IStudentService _studentService;
        public StudentModel()
        {

        }
        public StudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IList<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }
    }
}
