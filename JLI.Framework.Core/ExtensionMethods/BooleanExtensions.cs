using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Core {

    public static class BooleanExtensions {

        #region Boolean

        /// <summary>
        /// Returns a <see cref="bool"/> value as a JavaScript literal.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String ToJavaScriptLiteral(this bool value) {
            return value.ToString().ToLower();
        }

        /// <summary>
        /// Returns a <see cref="bool"/> value as a "Yes" or "No" string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String ToYesNo(this bool value) {
            return value.ToDisplayString("Yes", "No");
        }

        /// <summary>
        /// Returns a custome <see cref="String"/> value based on the <paramref name="value"/> provided.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trueString">Text returned if "true"</param>
        /// <param name="falseString">Text returned if "false"</param>
        /// <returns></returns>
        public static String ToDisplayString(this bool value, String trueString, String falseString) {
            return value ? trueString : falseString;
        }

        #endregion Boolean

        #region Nullable Boolan

        /// <summary>
        /// Returns a <see cref="bool?"/> value as a JavaScript literal.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String ToJavaScriptLiteral(this bool? value) {
            if (!value.HasValue)
                return Constants.JavaScript.Null;
            return value.Value.ToJavaScriptLiteral();
        }

        #endregion Nullable Boolean
    }
}
