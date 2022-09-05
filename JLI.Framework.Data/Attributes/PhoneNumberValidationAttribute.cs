using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    public class PhoneNumberValidationAttribute : FormattedStringValidationAttribute {

        public PhoneNumberValidationAttribute()
            : base(Validator.IsValidPhoneNumber) { }

    }

}
