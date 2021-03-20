using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiltersMVC.Attributes
{
    public class NonEmptyRequiredAttribute: ValidationAttribute
    {
        public NonEmptyRequiredAttribute()
        {
            ErrorMessage = "Cannot be empty!";
        }

        public NonEmptyRequiredAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public override bool IsValid(object value)
        {
            return !String.IsNullOrWhiteSpace(value?.ToString());
        }
    }
}