using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    
    /// <summary>
    /// Ensures that <see cref="String"/> data is valid according to the validation routine provided.
    /// </summary>
    public class FormattedStringValidationAttribute : ValidationAttribute {

        #region Constructor(s)

        public FormattedStringValidationAttribute(Func<String?, bool> validationRoutine, bool allowNullOrEmptyString) {
            ArgumentNullException.ThrowIfNull(validationRoutine, nameof(validationRoutine));
            this.ValidationRoutine = validationRoutine;
            this.AllowNullOrEmptyString = allowNullOrEmptyString;
        }

        #endregion Constructor(s)

        #region Properties

        /// <summary>
        /// Validation method to be invoked in order to determine data's validity
        /// </summary>
        protected Func<String?, bool> ValidationRoutine { get; private set; }

        protected bool AllowNullOrEmptyString { get; private set; }

        #endregion Properties

        #region Overrides

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {
            String? stringValue = value?.ToString();
            if (this.AllowNullOrEmptyString && String.IsNullOrEmpty(stringValue))
                return ValidationResult.Success;

            ValidationResult? validationResult = base.IsValid(value, validationContext);
            if (validationResult == ValidationResult.Success) {
                bool isValid = this.ValidationRoutine.Invoke(stringValue);
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

        #endregion Overrides

    }
}
