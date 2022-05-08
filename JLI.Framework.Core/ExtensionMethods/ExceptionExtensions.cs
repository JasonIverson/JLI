﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Core {
    public static class ExceptionExtensions {

        /// <summary>
        /// Recursively traverses an exception's inner exception and builds a comprehensive message with all exception details.
        /// </summary>
        /// <param name="exception">The exceptoin</param>
        /// <param name="separator">Separator appended between exception messages</param>
        /// <returns></returns>
        public static String Traverse(this Exception exception, String separator = "\r\n\r\n") {
            StringBuilder builder = new StringBuilder();

            Exception realException = exception;
            while (realException != null) {
                builder.Append(realException.Message);
                realException = realException.InnerException;
                if (realException != null)
                    builder.Append(separator);
            }

            return builder.ToString();
        }

    }
}
