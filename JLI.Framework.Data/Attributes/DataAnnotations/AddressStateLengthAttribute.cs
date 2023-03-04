using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public class AddressStateLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressStateLengthAttribute()
            : base(2) { }

        #endregion Constructor(s)

    }
}
