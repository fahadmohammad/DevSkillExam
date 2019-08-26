using FinalExam.Data.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.UOW
{
    public class CourseUnitOfWork : UnitOfWork<TestDbContext>
    {
        public CourseRepository Courses { get; set; }
        public CourseUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {            
            Courses = new CourseRepository(dbContext);
        }
    }
}
