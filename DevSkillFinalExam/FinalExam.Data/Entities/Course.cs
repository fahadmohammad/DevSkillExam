using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalExam.Data.Entities
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string TeacherName { get; set; }

        [Required]
        public int Credit { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
