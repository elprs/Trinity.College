using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "Required field"), MinLength(2), MaxLength(50)]
        public string Title { get; set; }

        //Navigation Properties
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int AssignmentId { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
