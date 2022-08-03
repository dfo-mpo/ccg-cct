using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Business.Dtos.JobCompetencies;
using DataModel.Services;

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
                    if (valueList.Any())
                    {
                        return ValidationResult.Success;
                    }
                }
                return new ValidationResult(errMsg);
            }
        }

        public sealed class BothOrNone : ValidationAttribute
        {

            public string OtherFieldName { get; set; }
            public string ErrMessage { get; set; }

            public BothOrNone(string name, string err) : base()
            {
                OtherFieldName = name;
                ErrMessage = err;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var otherField = validationContext.ObjectInstance.GetType().GetProperty(OtherFieldName);
                var otherFieldValue = otherField.GetValue(validationContext.ObjectInstance, null);

                if ((value == null && otherFieldValue != null) || (value != null && otherFieldValue == null))
                {
                    return new ValidationResult(ErrMessage);
                }

                return ValidationResult.Success;
            }
        }

    }
}