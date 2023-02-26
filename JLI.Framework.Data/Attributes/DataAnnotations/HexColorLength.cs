namespace JLI.Framework.Data {
    public class HexColorLength : System.ComponentModel.DataAnnotations.StringLengthAttribute {

        #region Constructor(s)

        public HexColorLength()
            : base(6) { }

        #endregion Constructor(s)

    }
}
