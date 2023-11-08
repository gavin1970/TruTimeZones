using System;
using System.Collections.Generic;
using System.Linq;

namespace TruTimeZones
{
    public class TimeZoneSearch
    {
        /// <summary>
        /// Will search all timezone as Exact or Contains.<br/>
        /// Search is NOT CASE sensitive.
        /// </summary>
        /// <param name="timeZoneId">Timezone Id to search for.</param>
        /// <param name="contains">
        /// <code>
        /// Search within the Id.<br/>
        ///     Default: false
        /// </code>
        /// </param>
        /// <returns>
        /// <code>
        /// TruTimeZone:<br/>
        ///     TimeSpan BaseUtcOffset<br/>
        ///     TimeSpan DSTUtcOffset<br/>
        ///     string DisplayName<br/>
        ///     string DaylightName<br/>
        ///     string Id<br/>
        ///     string StandardName<br/>
        ///     bool SupportsDaylightSavingTime<br/>
        ///     bool IsDaylightSavingTime
        /// </code>
        /// </returns>
        public static TruTimeZone SearchById(string timeZoneId, bool contains = false)
        {
            //Contains does have StringComparison properties, so it has to be lower cased.
            if (contains)
                return WorldTimeZones.TimeZones.Find(f => f.Id.ToLower().Contains(timeZoneId.ToLower()));
            else
                return WorldTimeZones.TimeZones.Find(f => f.Id.Equals(timeZoneId, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Will search all timezone as Exact or Contains.<br/>
        /// Search is NOT CASE sensitive.
        /// </summary>
        /// <param name="timeZoneId">Timezone Id to search for.</param>
        /// <param name="contains">
        /// <code>
        /// Search within the Id.<br/>
        ///     Default: false
        /// </code>
        /// </param>
        /// <returns>
        /// <code>
        /// TruTimeZone:<br/>
        ///     TimeSpan BaseUtcOffset<br/>
        ///     TimeSpan DSTUtcOffset<br/>
        ///     string DisplayName<br/>
        ///     string DaylightName<br/>
        ///     string Id<br/>
        ///     string StandardName<br/>
        ///     bool SupportsDaylightSavingTime<br/>
        ///     bool IsDaylightSavingTime
        /// </code>
        /// </returns>
        public static TruTimeZone SearchByName(string displayName, bool contains = false)
        {
            //Contains does have StringComparison properties, so it has to be lower cased.
            if (contains)
                return WorldTimeZones.TimeZones.Find(f => f.DisplayName.ToLower().Contains(displayName.ToLower()));
            else
                return WorldTimeZones.TimeZones.Find(f => f.DisplayName.Equals(displayName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Pull Local and Current TimeZon information.
        /// </summary>
        /// <returns>
        /// <code>
        /// TruTimeZone:<br/>
        ///     TimeSpan BaseUtcOffset<br/>
        ///     TimeSpan DSTUtcOffset<br/>
        ///     string DisplayName<br/>
        ///     string DaylightName<br/>
        ///     string Id<br/>
        ///     string StandardName<br/>
        ///     bool SupportsDaylightSavingTime<br/>
        ///     bool IsDaylightSavingTime
        /// </code>
        /// </returns>
        public static TruTimeZone CurrentTimeZone()
        {
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
            return GetTimeZones().First(f => f.Id == tzi.Id);
        }

        /// <summary>
        /// Get a list of all TimeZones and all their information.
        /// </summary>
        /// <returns>
        /// <code>
        /// List<TruTimeZone><br/>
        /// TruTimeZone:<br/>
        ///     TimeSpan BaseUtcOffset<br/>
        ///     TimeSpan DSTUtcOffset<br/>
        ///     string DisplayName<br/>
        ///     string DaylightName<br/>
        ///     string Id<br/>
        ///     string StandardName<br/>
        ///     bool SupportsDaylightSavingTime<br/>
        ///     bool IsDaylightSavingTime
        /// </code>
        /// </returns>
        public static IEnumerable<TruTimeZone> GetTimeZones()
        {
            return WorldTimeZones.TimeZones.OrderBy(o=>o.BaseUtcOffset);
        }
    }
}
