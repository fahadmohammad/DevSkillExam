using FinalExam.Data.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.UOW
{
    public class StudentUnitOfwork : UnitOfWork<TestDbContext>
    {
        public StudentRepository Students { get; set; }

        public StudentUnitOfwork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            Students = new StudentRepository(dbContext);            
        }
    }
}
