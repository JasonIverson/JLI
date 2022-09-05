using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    public class FormattedStringValidationAttribute : ValidationAttribute {

        public FormattedStringValidationAttribute(Func<String?, bool> validation) {
            this.Validation = validation;
        }

        protected Func<String?, bool> Validation { get; private set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {
            ValidationResult? validationResult = base.IsValid(value, validationContext);
            if (validationResult == ValidationResult.Success) {
                String? stringValue = value?.ToString();

                bool isValid = this.Validation.Invoke(stringValue);
                if (!isValid) {
                    String errorMessage = this.FormatErrorMessage(validationContext.DisplayName);
                    IEnumerable<String>? memberNames = null;
                    if (!String.IsNullOrWhiteSpace(validationContext.MemberName)) {
                        memberNames = new String[] { validationContext.MemberName };
                    }
                    validationResult = new ValidationResult(errorMessage, memberNames);
                }
            }
            return validationResult;
        }

    }
}
