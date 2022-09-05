using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    
    public class EmailAddressValidationAttribute : FormattedStringValidationAttribute {

        public EmailAddressValidationAttribute()
            : base(Validator.IsValidEmailAddress) { }

    }

}
