using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    public class HexColorLength : System.ComponentModel.DataAnnotations.StringLengthAttribute {

        #region Constructor(s)

        public HexColorLength()
            : base(6) { }

        #endregion Constructor(s)

    }
}
