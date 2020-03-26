using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [Required(ErrorMessage = "Required field"), MinLength(2), MaxLength(50)]
        public string Title { get; set; }

        public virtual Student Student { get; set; }
    }
}
