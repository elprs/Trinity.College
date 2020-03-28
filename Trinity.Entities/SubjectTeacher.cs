using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Entities
{
   public class SubjectTeacher
    {
        [Key, Column(Order = 1)]
        public int SubjectId { get; set; }
        [Key, Column(Order = 2)]
        public int TeacherId { get; set; }


        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
