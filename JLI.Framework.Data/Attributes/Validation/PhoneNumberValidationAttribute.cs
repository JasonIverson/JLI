using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    /// <summary>
    /// Validation attribute used to ensure data entered is a valid 10 digit US phone number
    /// </summary>
    public class PhoneNumberValidationAttribute : FormattedStringValidationAttribute {

        #region Constructor(s)

        public PhoneNumberValidationAttribute(bool allowNullOrEmptyString)
            : base(Validator.IsValidPhoneNumber, allowNullOrEmptyString) { }

        #endregion Constructor(s)

    }

}
