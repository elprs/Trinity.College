using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
       
    }
}
