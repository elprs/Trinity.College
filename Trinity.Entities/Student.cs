using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string LastName { get; set; } 
        [DataType(DataType.PhoneNumber), Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Required field")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                ErrorMessage = "Entered phone format is not valid.")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Required field"), EmailAddress]
        public string Email { get; set; }
        //Navigation Properties
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }

    }
}
