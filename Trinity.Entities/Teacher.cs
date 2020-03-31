﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Trinity.Entities.CustomValidations;

namespace Trinity.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber), Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Required field")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                ErrorMessage = "Entered phone format is not valid.")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Required field"), EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Images")]
        public List<string> ImagesURLs { get; set; } = new List<string> { @"Trinity.College\Images\no-image-available.png"}; //images from the lessons
        [CustomValidation(typeof(ValidationMethods), "ValidateGreaterOrEqualToZero")]
        [Display(Name = "Monthly Salary")]
        public double Salary { get; set; }
        [Display(Name = "Lesson Video")]
        public string VideoURL { get; set; } = @"Trinity.College\Images\no-image-available.png"; //video from the lessons


        //Navigation Properties
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
