using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    public  class UrlValidationAttribute : FormattedStringValidationAttribute {

        public UrlValidationAttribute()
            : base(Validator.IsValidUrl) { }

    }

}
