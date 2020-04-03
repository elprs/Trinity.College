using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "Required field"), MinLength(2), MaxLength(50)]
        public string Title { get; set; }
        [Display(Name = "Image")]
        public string PhotoURL { get; set; } = @"https://image.shutterstock.com/image-vector/no-image-available-vector-illustration-260nw-744886198.jpg";
        //Navigation Properties
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
