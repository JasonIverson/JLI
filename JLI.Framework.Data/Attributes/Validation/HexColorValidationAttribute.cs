namespace JLI.Framework.Data {

    /// <summary>
    /// Validation attribute used to ensure data entered is a valid 3 or 6 character RGB hexidecimal color
    /// </summary>
    public class HexColorValidationAttribute : FormattedStringValidationAttribute {

        #region Constructor(s)

        public HexColorValidationAttribute(bool allowNullOrEmptyString)
            : base(Validator.IsValidHexColor, allowNullOrEmptyString) { }

        #endregion Constructor(s)

    }

}
