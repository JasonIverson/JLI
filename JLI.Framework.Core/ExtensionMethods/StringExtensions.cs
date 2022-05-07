using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Core
{
    public static class StringExtensions
    {

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

    }
}
