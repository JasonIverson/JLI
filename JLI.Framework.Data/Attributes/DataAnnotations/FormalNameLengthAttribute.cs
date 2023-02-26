using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public class FormalNameLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public FormalNameLengthAttribute()
            : base(64) { }

        #endregion Constructor(s)

    }
}
