using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data.Attributes.DataAnnotations {
    public class PhoneNumberLengthAttribute : StringLengthAttribute {

        #region Constants

        public const int LENGTH = 16;

        #endregion Constants

        #region Constructor(s)

        public PhoneNumberLengthAttribute()
            : base(LENGTH) { }

        #endregion Constructor(s)

    }
}
