namespace JLI.Framework.Data {
    public class FormalNameLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute {

        #region Constructor(s)

        public FormalNameLengthAttribute()
            : base(64) { }

        #endregion Constructor(s)

    }
}
