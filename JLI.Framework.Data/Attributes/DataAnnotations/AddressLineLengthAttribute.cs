using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {

    public class AddressLineLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressLineLengthAttribute()
            : base(64) { }

        #endregion Constructor(s)

    }

}
