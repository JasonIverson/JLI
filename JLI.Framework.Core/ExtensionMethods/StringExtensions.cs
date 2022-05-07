using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Core
{
    public static class StringExtensions
    {

        #region String Extensions

        /// <summary>
        /// Returns a "string in this format" as a "String In This Format"
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String ToTitleCase(this String source)
        {
            if (String.IsNullOrWhiteSpace(source))
                return source;
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(source);
        }

        #endregion

        #region IEnumerable<String> Extensions

        /// <summary>
        /// Returns the first non-null or white space value, or null in the event that no values are found.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String Coalesce(this IEnumerable<String> source)
        {
            String returnValue = null;
            if (source != null && source.Any())
            {
                foreach(String value in source)
                {
                    if (!String.IsNullOrWhiteSpace(value))
                    {
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
