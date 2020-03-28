using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class CourseStudent
    {
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        [Key, Column(Order = 2)]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Required field")]
        public bool IsFeePayed { get; set; } = false; 
        //Navigation Properties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}
