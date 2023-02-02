﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    
    public class UrlLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute {

        #region Constructor(s)

        public UrlLengthAttribute()
            : base(256) { }

        #endregion Constructor(s)

    }
}