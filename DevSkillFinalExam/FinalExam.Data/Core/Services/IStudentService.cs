using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.Services
{
    public interface IStudentService : IDisposable
    {
        void CreateStudent(Student student);
        Student GetStudent(Guid id);
        IList<Student> GetStudents();
        void EditStudent(Student student);
        void DeleteStudent(Student student);

    }
}
