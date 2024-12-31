﻿namespace System {
    public static class DateTimeExtensions {

        #region DateTime

        /// <summary>
        /// Localizes a <see cref="DateTime"/> in Utc to the Timezone specified by <paramref name="toTimezoneId"/>.
        /// </summary>
        /// <param name="dateTimeUtc"></param>
        /// <param name="toTimezoneId"></param>
        /// <returns></returns>
        public static DateTime Localize(this DateTime dateTimeUtc, string toTimezoneId) {
            TimeZoneInfo timezoneInfo = TimeZoneInfo.FindSystemTimeZoneById(toTimezoneId);
            DateTime returnValue = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc.ToUniversalTime(), timezoneInfo);
            return returnValue;
        }

        #endregion DateTime

        #region DateTime?

        /// <summary>
        /// Localizes a <see cref="DateTime?"/> in Utc to the Timezone specified by <paramref name="toTimezoneId"/>.
        /// </summary>
        /// <param name="dateTimeUtc"></param>
        /// <param name="toTimezoneId"></param>
        /// <returns></returns>
        public static DateTime? Localize(this DateTime? dateTimeUtc, string toTimezoneId) {
            if (!dateTimeUtc.HasValue)
                return dateTimeUtc;

            DateTime returnValue = dateTimeUtc.Value.Localize(toTimezoneId);
            return returnValue;
        }

        #endregion DateTime?

    }
}
