using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class Mark
    {
        //This class references the Marks of a Subject for every Student
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Key, Column(Order = 2)]
        public int AssignmentId { get; set; }

        [Required(ErrorMessage = "Required field"), Range(0.0D, 200.0D)]
        public double MarkUniqueCode { get; set; }
        [Required(ErrorMessage = "Required field"), Range(0, 100)]
        public double AssignmentMark { get; set; } = 0.0D;
        [Required(ErrorMessage = "Required field"), Range(0.0D, 100.0D)]
        public double OralMark { get; set; } = 0;
        public double? TotalMark { get; set; }
        //Navigation Properties
        
        public virtual Student Student { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
