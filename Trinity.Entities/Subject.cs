using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public int CourseId { get; set; }

        [Required(ErrorMessage = "Required field"), MinLength(2), MaxLength(50)]
        public string Title { get; set; }
        public string PhotoURL { get; set; } = "Trinity.College\\Images\\no-image-available.png";
        //Navigation Properties
        
        public virtual Course Course { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
