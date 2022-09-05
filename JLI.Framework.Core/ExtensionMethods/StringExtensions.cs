using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JLI.Framework.Core.Constants;

namespace System {
    public static class StringExtensions {

        #region String Extensions

        /// <summary>
        /// Normalizes a <see cref="String"/>'s character casing for comparison operations where case sensitivity is important
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String Normalize(this String source) {
            if (String.IsNullOrWhiteSpace(source))
                return source;
            return source.ToUpper();
        }

        /// <summary>
        /// Removes any non-digit characters from a <see cref="String"/>, and returns what remains of the String.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String ToDigits(this String value) {
            if (String.IsNullOrWhiteSpace(value))
                return value;

            String returnValue = Regex.Replace(value, @"\D+", String.Empty);
            return returnValue;
        }

        /// <summary>
        /// Returns a <see cref="String"/> value as a JavaScript literal, enclosed in quotes.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String ToJavaScriptLiteral(this String? value) {
            if (value == null)
                return JavaScript.Null;
            return $"{JavaScript.DoubleQuote}{value.Replace("\"", "\\\"")}{JavaScript.DoubleQuote}";
        }

        /// <summary>
        /// Returns a "string in this format" as a "String In This Format"
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String ToTitleCase(this String source) {
            if (String.IsNullOrWhiteSpace(source))
                return source;
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(source);
        }

        /// <summary>
        /// Url decodes the <see cref="String"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String? UrlDecode(String? source) {
            if (source == null)
                return source;
            return System.Web.HttpUtility.UrlDecode(source);
        }

        /// <summary>
        /// Url encodes the <see cref="String"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String? UrlEncode(this String? source) {
            if (source == null)
                return source;
            return System.Web.HttpUtility.UrlEncode(source);
        }

        #endregion

        #region IEnumerable<String> Extensions

        /// <summary>
        /// Returns the first non-null or white space value, or optionally provided <paramref name="defaultValue"/>, in the event that no values are found.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static String? Coalesce(this IEnumerable<String> source, String? defaultValue = null) {
            String? returnValue = defaultValue;
            if (source?.Any() ?? false) {
                foreach (String value in source) {
                    if (!String.IsNullOrWhiteSpace(value)) {
                        returnValue = value;
                        break;
                    }
                }
            }
            return returnValue;
        }

        #endregion IEnumerable<String> Extensions

    }
}
