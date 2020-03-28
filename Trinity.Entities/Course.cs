using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Required field")]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "Required field")]
        Type Type { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required field")]
        [Range(0, 1000000)]
        public double Fee { get; set; }
        //Navigation Properties
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
