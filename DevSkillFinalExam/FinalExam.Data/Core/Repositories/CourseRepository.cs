using FinalExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.Repositories
{
    public class CourseRepository : Repository<Course>
    {
        public CourseRepository(TestDbContext testDbContext)
            : base(testDbContext)
        {

        }
    }
}
