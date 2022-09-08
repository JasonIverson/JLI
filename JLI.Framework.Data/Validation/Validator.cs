using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    public static class Validator {

        #region Fields

        private static readonly TimeSpan RegexTimeout = TimeSpan.FromMilliseconds(200);

        #endregion Fields

        /// <summary>
        /// Determines whether the <paramref name="emailAddress"/> is in the form of a valid email address.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        public static bool IsValidEmailAddress(String? emailAddress) {
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            if (String.IsNullOrWhiteSpace(emailAddress))
                return false;

            try {
                // Normalize the domain
                emailAddress = Regex.Replace(emailAddress, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, Validator.RegexTimeout);

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match) {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException) {
                return false;
            }
            catch (ArgumentException) {
                return false;
            }

            try {
                return Regex.IsMatch(emailAddress, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, 
                    TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException) {
                return false;
            }
        }

        /// <summary>
        /// Determines if the <paramref name="phoneNumber"/> is in the form of a valid 10 digit US phone number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool IsValidPhoneNumber(String? phoneNumber) {
            if (String.IsNullOrWhiteSpace(phoneNumber))
                return false;

            bool result = Regex.IsMatch(phoneNumber, @"^\d{10}$", RegexOptions.None, Validator.RegexTimeout) &&
                !phoneNumber.StartsWith("1"); // US area codes do not begin with a 1
            return result;
        }

        /// <summary>
        /// Determines whether the <paramref name="url"/> is in the form of a valid HTTP or HTTPS Absolute Url.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsValidUrl(String? url) {
            // https://stackoverflow.com/a/7581824
            if (String.IsNullOrWhiteSpace(url))
                return false;

            bool result = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

    }

}
