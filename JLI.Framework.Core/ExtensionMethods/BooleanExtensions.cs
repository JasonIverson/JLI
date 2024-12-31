using JLI.Framework.Core.Constants;

namespace System {

    public static class BooleanExtensions {

        #region Boolean

        /// <summary>
        /// Returns a <see cref="bool"/> value as a JavaScript literal.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToJavaScriptLiteral(this bool value) {
            return value.ToString().ToLower();
        }

        /// <summary>
        /// Returns a <see cref="bool"/> value as a "Yes" or "No" string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToYesNo(this bool value) {
            return value.ToDisplayString("Yes", "No");
        }

        /// <summary>
        /// Returns a custome <see cref="string"/> value based on the <paramref name="value"/> provided.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trueString">Text returned if "true"</param>
        /// <param name="falseString">Text returned if "false"</param>
        /// <returns></returns>
        public static string ToDisplayString(this bool value, string trueString, string falseString) {
            return value ? trueString : falseString;
        }

        #endregion Boolean

        #region Nullable Boolean

        /// <summary>
        /// Returns a <see cref="bool?"/> value as a JavaScript literal.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToJavaScriptLiteral(this bool? value) {
            if (!value.HasValue)
                return JavaScript.Null;
            return value.Value.ToJavaScriptLiteral();
        }

        #endregion Nullable Boolean

        #region IEnumerable<bool?>

        /// <summary>
        /// Returns the first non-null value, or optionally provided <paramref name="defaultValue"/>, in the event that no values are found.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static bool? Coalesce(IEnumerable<bool?> source, bool? defaultValue = null) {
            bool? returnValue = defaultValue;
            if (source?.Any() ?? false) {
                foreach (bool? value in source) {
                    if (value.HasValue) {
                        returnValue = value;
                        break;
                    }
                }
            }
            return returnValue;
        }

        #endregion IEnumerable<bool?>

    }
}
