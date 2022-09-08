using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    /// <summary>
    /// Validation attribute used to ensure data entered is a valid email address
    /// </summary>
    public class EmailAddressValidationAttribute : FormattedStringValidationAttribute {

        #region Constructor(s)

        public EmailAddressValidationAttribute()
            : base(Validator.IsValidEmailAddress) { }

        #endregion Constructor(s)

    }

}
