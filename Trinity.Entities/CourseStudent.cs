using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Entities
{
    public class CourseStudent
    {
            [Key, Column(Order = 1)]
            public int CourseId { get; set; }
            [Key, Column(Order = 2)]
            public int StudentId { get; set; }

            public bool IsFeePayed { get; set; }

        //Navigation Properties
        public virtual Course Course { get; set; }
            public virtual Student Student { get; set; }
        
    }
}
