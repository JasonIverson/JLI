using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public class AddressRegionLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressRegionLengthAttribute()
            : base(64) { }

        #endregion Constructor(s)

    }
}
