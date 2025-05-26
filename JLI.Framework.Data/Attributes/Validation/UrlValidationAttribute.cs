﻿namespace JLI.Framework.Data {

    /// <summary>
    /// Validation attribute used to ensure data entered is a valid HTTP or HTTPS Url
    /// </summary>
    public class UrlValidationAttribute : FormattedStringValidationAttribute {

        #region Constructor(s)

        public UrlValidationAttribute(bool allowNullOrEmptyString)
            : base(Validator.IsValidUrl, allowNullOrEmptyString) { }

        #endregion Constructor(s)

    }

}
