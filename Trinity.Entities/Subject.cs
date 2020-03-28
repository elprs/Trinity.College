using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "Required field"), MinLength(2), MaxLength(50)]
        public string Title { get; set; }
        public string PhotoURL { get; set; } = "Trinity.College\\Images\\no-image-available.png";
        //Navigation Properties
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
