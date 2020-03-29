using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities
{
    public class Mark
    {
        //This class references the Marks of a Subject for every Student
        public int MarkId { get; set; }
        [Required, Range(0, 100)]
        public int AssignmentMark { get; set; } = 0;
        [Required, Range(0, 100)]
        public int OralMark { get; set; } = 0;
        public double? TotalMark { get; set; }
        //Navigation Properties
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
