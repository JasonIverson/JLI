using System.ComponentModel.DataAnnotations;
    
namespace JLI.Framework.Data {
    
    public class UrlLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public UrlLengthAttribute()
            : base(256) { }

        #endregion Constructor(s)

    }
}
