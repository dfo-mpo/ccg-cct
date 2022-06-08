using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DataModel
{
    public class CustomValidation
    {
        public sealed class CheckOneRegionSelected : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                string errMsg = "Make sure that at least one region is selected";
                if (value != null)
                {
                    List<string> valueList = (List<string>)value;
                    if (valueList.Count > 0)
                    {
                        return ValidationResult.Success;
                    } // if
                } // if
                return new ValidationResult(errMsg);
            } // IsValid()
        } // CheckOneRegionSelected class

    } // CustomValidation class
} // namespace