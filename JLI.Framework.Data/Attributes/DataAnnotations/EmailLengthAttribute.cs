using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public class EmailLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public EmailLengthAttribute()
            : base(64) { }

        #endregion Constructor(s)

    }
}
