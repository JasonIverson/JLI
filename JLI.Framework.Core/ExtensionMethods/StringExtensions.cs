using System.Text.RegularExpressions;
using JLI.Framework.Core.Constants;

namespace System {
    public static class StringExtensions {

        #region string Extensions

        /// <summary>
        /// Normalizes a <see cref="string"/>'s character casing for comparison operations where case sensitivity is important
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string? Normalize(this string? source) {
            if (string.IsNullOrWhiteSpace(source))
                return source;
            return source.ToUpper();
        }

        /// <summary>
        /// Removes any non-digit characters from a <see cref="string"/>, and returns what remains of the string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string? ToDigits(this string? value) {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string returnValue = Regex.Replace(value, @"\D+", string.Empty);
            return returnValue;
        }

        /// <summary>
        /// Returns a <see cref="string"/> value as a JavaScript literal, enclosed in quotes.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToJavaScriptLiteral(this string? value) {
            if (value == null)
                return JavaScript.Null;
            return $"{JavaScript.DoubleQuote}{value.Replace("\"", "\\\"")}{JavaScript.DoubleQuote}";
        }

        /// <summary>
        /// Returns a "string in this format" as a "String In This Format"
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string? ToTitleCase(this string? source) {
            if (string.IsNullOrWhiteSpace(source))
                return source;
            return Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(source);
        }

        /// <summary>
        /// Url decodes the <see cref="string"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string? UrlDecode(string? source) {
            if (source == null)
                return source;
            return Web.HttpUtility.UrlDecode(source);
        }

        /// <summary>
        /// Url encodes the <see cref="string"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string? UrlEncode(this string? source) {
            if (source == null)
                return source;
            return Web.HttpUtility.UrlEncode(source);
        }

        #endregion

        #region IEnumerable<string> Extensions

        /// <summary>
        /// Returns the first non-null or white space value, or optionally provided <paramref name="defaultValue"/>, in the event that no values are found.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string? Coalesce(this IEnumerable<string?> source, string? defaultValue = null) {
            string? returnValue = defaultValue;
            if (source?.Any() ?? false) {
                foreach (string? value in source) {
                    if (!string.IsNullOrWhiteSpace(value)) {
                        returnValue = value;
                        break;
                    }
                }
            }
            return returnValue;
        }

        #endregion IEnumerable<string> Extensions

    }
}
