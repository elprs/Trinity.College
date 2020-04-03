using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities
{
    public class Assignment
    {   
        public int AssignmentId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Date)]
        [Display(Name = "Submission date")]
        public DateTime SubDate { get; set; }
        //Navigation Property
        public virtual ICollection<Mark> Marks { get; set; }
    }
}