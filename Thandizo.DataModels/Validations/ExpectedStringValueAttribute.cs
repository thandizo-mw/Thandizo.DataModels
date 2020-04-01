using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Thandizo.DataModels.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.Field, AllowMultiple = true)]
    public sealed class ExpectedStringValueAttribute : ValidationAttribute
    {
        private readonly string _expectedValues;

        public ExpectedStringValueAttribute(string expectedValues)
        {
            _expectedValues = expectedValues;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IEnumerable<string> values = Enumerable.Empty<string>();

            // Check if multiple values were specified
            if (_expectedValues.Contains(","))
            {
                var valueCollection = _expectedValues.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                values = valueCollection;
            }
            else
            {
                values = new string[] { _expectedValues };
            }

            if (!values.Contains(value.ToString()))
            {
                var valueString = values.Count() == 1 ? "value" : "values";
                return new ValidationResult($"Input was expecting {_expectedValues} as valid {valueString}");
            }
            return ValidationResult.Success;
        }
    }
}
