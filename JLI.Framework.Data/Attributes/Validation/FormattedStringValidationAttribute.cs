using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {

    /// <summary>
    /// Ensures that <see cref="string"/> data is valid according to the validation routine provided.
    /// </summary>
    public class FormattedStringValidationAttribute : ValidationAttribute {

        #region Constructor(s)

        public FormattedStringValidationAttribute(Func<string?, bool> validationRoutine, bool allowNullOrEmptyString) {
            ArgumentNullException.ThrowIfNull(validationRoutine, nameof(validationRoutine));
            this.ValidationRoutine = validationRoutine;
            this.AllowNullOrEmptyString = allowNullOrEmptyString;
        }

        #endregion Constructor(s)

        #region Properties

        /// <summary>
        /// Validation method to be invoked in order to determine data's validity
        /// </summary>
        protected Func<string?, bool> ValidationRoutine { get; private set; }

        protected bool AllowNullOrEmptyString { get; private set; }

        #endregion Properties

        #region Overrides

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {
            string? stringValue = value?.ToString();
            if (this.AllowNullOrEmptyString && string.IsNullOrEmpty(stringValue))
                return ValidationResult.Success;

            ValidationResult? validationResult = base.IsValid(value, validationContext);
            if (validationResult == ValidationResult.Success) {
                bool isValid = this.ValidationRoutine.Invoke(stringValue);
                if (!isValid) {
                    string errorMessage = this.FormatErrorMessage(validationContext.DisplayName);
                    IEnumerable<string>? memberNames = null;
                    if (!string.IsNullOrWhiteSpace(validationContext.MemberName)) {
                        memberNames = new string[] { validationContext.MemberName };
                    }
                    validationResult = new ValidationResult(errorMessage, memberNames);
                }
            }
            return validationResult;
        }

        #endregion Overrides

    }
}
