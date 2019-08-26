using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Entities
{
    public class TeacherStudnets
    {
        public Guid TeachertId { get; set; }
        public Guid StudentId { get; set; }

        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        
    }
}
