using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Trinity.Entities.CustomValidations;

namespace Trinity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DateGreaterThan("StartDate")]
        [Display(Name = "Finish Date")]
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "Required field")]
       public Type Type { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required field")]
        [Range(0, 1000000)]
        [Display(Name = "Image")]
        public string PhotoURL { get; set; } = @"Trinity.College\Images\no-image-available.png";
        [Required(ErrorMessage = "Required field")]
        public double Fee { get; set; }
        //Navigation Properties
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
