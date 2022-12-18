using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    public class QuerySettings<TModel>
        where TModel : Models.Model, new() {

        #region Constructor(s)

        public QuerySettings(bool trackingEnabled) {
            this.TrackingEnabled = trackingEnabled;
        }

        #endregion Constructor(s)

        #region Properties

        public bool TrackingEnabled { get; set; }

        #endregion Properties

    }
}
