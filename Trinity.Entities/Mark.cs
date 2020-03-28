using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Entities
{
    public class Mark
    {
        //This class references the Marks of a Subject for every Student
        public int MarkId { get; set; }
        public int AssignmentMark { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //Navigation Properties
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
