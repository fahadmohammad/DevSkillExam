using FinalExam.Data.Core.UOW;
using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExam.Data.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentUnitOfwork _studentUnitOfwork;

        public StudentService(StudentUnitOfwork studentUnitOfwork)
        {
            _studentUnitOfwork = studentUnitOfwork;
        }

        public IList<Student> GetStudents()
        {
            return _studentUnitOfwork.Students.GetAll().ToList();
        }
        public void CreateStudent(Student student)
        {
            _studentUnitOfwork.Students.Add(student);
            _studentUnitOfwork.Save();
        }

        public void DeleteStudent(Student student)
        {
            _studentUnitOfwork.Students.Remove(student);
            _studentUnitOfwork.Save();
        }

        public void Dispose()
        {
            _studentUnitOfwork.Dispose();
        }

        public void EditStudent(Student student)
        {
            _studentUnitOfwork.Students.Edit(student);
            _studentUnitOfwork.Save();
        }

        public Student GetStudent(Guid id)
        {
            return _studentUnitOfwork.Students.Get(x => x.Id == id).FirstOrDefault();
        }

        

    }
}
