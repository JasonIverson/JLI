﻿using JLI.Framework.Data.Attributes.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

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
        public static bool IsValidEmailAddress(string? emailAddress) {
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            if (string.IsNullOrWhiteSpace(emailAddress))
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
        public static bool IsValidPhoneNumber(string? phoneNumber) {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            string pattern = $"^\\d{{{PhoneNumberLengthAttribute.LENGTH}}}$";
            bool result = Regex.IsMatch(phoneNumber, pattern, RegexOptions.None, Validator.RegexTimeout) &&
                !phoneNumber.StartsWith("1"); // US area codes do not begin with a 1
            return result;
        }

        /// <summary>
        /// Determines whether the <paramref name="url"/> is in the form of a valid HTTP or HTTPS Absolute Url.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string? url) {
            // https://stackoverflow.com/a/7581824
            if (string.IsNullOrWhiteSpace(url))
                return false;

            bool result = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        /// <summary>
        /// Determines whether the <paramref name="hexColor"/> is in the form of a valid 3 or 6 character RGB hexidecimal color.
        /// </summary>
        /// <param name="hexColor"></param>
        /// <returns></returns>
        public static bool IsValidHexColor(string? hexColor) {
            // https://stackoverflow.com/a/1636354
            if (string.IsNullOrWhiteSpace(hexColor))
                return false;

            bool result = Regex.IsMatch(hexColor, @"^(?:[0-9a-fA-F]{3}){1,2}$", RegexOptions.None, Validator.RegexTimeout);
            return result;
        }

    }

}
