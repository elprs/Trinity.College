using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Type Type { get; set; }
        public string Description { get; set; }
        public int Fee { get; set; }

        //Navigation Properties
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
