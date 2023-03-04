using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    
    public class AddressPostalCodeLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressPostalCodeLengthAttribute()
            : base(9) { }

        #endregion Constructor(s)

    }

}
