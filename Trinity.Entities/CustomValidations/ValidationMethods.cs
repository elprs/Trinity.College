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
                return new ValidationResult(string.Format("The field {0} must be greater than or equal to 0.", context.MemberName), new List<string> { context.MemberName });
            }
        }
    }

    public class DateGreaterThan : ValidationAttribute
    {
        private string _startDatePropertyName;
        public DateGreaterThan(string startDatePropertyName)
        {
            _startDatePropertyName = startDatePropertyName;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(_startDatePropertyName);
            var propertyValue = propertyInfo.GetValue(validationContext.ObjectInstance, null);
            if ((DateTime)value > (DateTime)propertyValue)
            {
                return ValidationResult.Success;
            }
            else if ((DateTime)value == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                var startDateDisplayName = propertyInfo
                                                       .GetCustomAttributes(typeof(DisplayAttribute), true)
                                                       .Cast<DisplayAttribute>()
                                                       .Single()
                                                       .Name;

                return new ValidationResult(validationContext.DisplayName + " must be later than " + startDateDisplayName + ".");

            }
        }
        //source : https://sensibledev.com/compare-validator-in-mvc/
    }
}
