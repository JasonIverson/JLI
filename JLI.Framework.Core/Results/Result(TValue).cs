using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Core {

    /// <summary>
    /// Represents the result of some action being taken, which also includes a return value for successful results.
    /// </summary>
    /// <typeparam name="TValue">The type of value to be returned</typeparam>
    public class Result<TValue>
        : Result {

        #region Constructor(s)

        internal Result(bool successful, String message, Exception exception, TValue returnValue)
            : base(successful, message, exception) {
            this.ReturnValue = returnValue;
        }

        #endregion Constructor(s)

        #region Properties

        public TValue ReturnValue { get; private set; }

        #endregion Properties

        #region Overrides

        public override string ToString() {
            if (this.Successful)
                return $"{base.ToString()}; {{ {this.ReturnValue} }}";
            return base.ToString();
        }

        #endregion Overrides

    }
}
