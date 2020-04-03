using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class Mark
    {
        //This class references the Marks of a Subject for every Student
        public int MarkId { get; set; }
        [Required(ErrorMessage = "Required field"), Range(0.0D, 200.0D)]
        [Display(Name = "Unique code")]
        public double UniqueCode { get; set; }
        [Required(ErrorMessage = "Required field"), Range(0D, 100D)]
        [Display(Name = "Assignment mark")]
        public double AssignmentMark { get; set; } = 0.0D;
        [Required(ErrorMessage = "Required field"), Range(0.0D, 100.0D)]
        [Display(Name = "Oral mark")]
        public double OralMark { get; set; } = 0.0D;
        [Display(Name = "Total mark")]
        [NotMapped]
        public double TotalMark { get; set; }

        //Navigation Properties
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
