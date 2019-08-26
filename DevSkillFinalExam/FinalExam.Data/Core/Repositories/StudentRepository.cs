using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.Repositories
{
    public class StudentRepository : Repository<Student>
    {
        public StudentRepository(TestDbContext testDbContext)
            : base(testDbContext)
        {

        }
    }
}
