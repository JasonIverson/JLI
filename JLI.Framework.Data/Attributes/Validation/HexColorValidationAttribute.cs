using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    /// <summary>
    /// Validation attribute used to ensure data entered is a valid 6 character RGB hexidecimal color
    /// </summary>
    public class HexColorValidationAttribute : FormattedStringValidationAttribute {

        #region Constructor(s)

        public HexColorValidationAttribute()
            : base(Validator.IsValidHexColor) { }

        #endregion Constructor(s)

    }

}
