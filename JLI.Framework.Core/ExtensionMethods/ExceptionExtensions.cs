using System.Text;

namespace System {
    public static class ExceptionExtensions {

        /// <summary>
        /// Recursively traverses an exception's inner exception and builds a comprehensive message with all exception details.
        /// </summary>
        /// <param name="exception">The exceptoin</param>
        /// <param name="separator">Separator appended between exception messages</param>
        /// <returns></returns>
        public static string Traverse(this Exception exception, string separator = "\r\n\r\n") {
            StringBuilder builder = new StringBuilder();

            Exception? realException = exception;
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
