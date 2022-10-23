using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    public class FormalNameLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute {

        #region Constructor(s)

        public FormalNameLengthAttribute()
            : base(64) { }

        #endregion Constructor(s)

    }
}
