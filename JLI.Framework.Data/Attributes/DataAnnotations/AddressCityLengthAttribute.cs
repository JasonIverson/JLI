using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    
    public class AddressCityLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressCityLengthAttribute()
            : base(32) { }

        #endregion Constructor(s)

    }

}
