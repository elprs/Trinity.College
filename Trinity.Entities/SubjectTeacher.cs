using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class SubjectTeacher
    {
        [Key, Column(Order = 1)]
        public int SubjectId { get; set; }
        [Key, Column(Order = 2)]
        public int TeacherId { get; set; }
        //navigation Properties
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
