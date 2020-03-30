using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trinity.Entities
{
    public class Assignment
    {


        public int AssignmentId { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }

        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Date)]
        public DateTime SubDate { get; set; }
        //Navigation Properties
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }

    }
}
