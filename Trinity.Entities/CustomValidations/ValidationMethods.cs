using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trinity.Entities.CustomValidations
{
    public class ValidationMethods
    {
        public static ValidationResult ValidateGreaterOrEqualToZero(double value, ValidationContext context)
        {
            bool isValid = true;
            if (value < 0D)
            {
                isValid = false;
            }
            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("The field {0} must be greater than or EEEEEEEEEEEEEEEEEEEequal to 0.", context.MemberName), new List<string> { context.MemberName });
            }
        }
}
