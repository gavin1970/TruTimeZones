using System;

namespace TruTimeZones
{
    /// <summary>
    /// With Microsoft issues with Timezones and offsets, this set of classes should resolve this issue.
    /// </summary>
    public class TruTimeZone
    {
        internal TruTimeZone(TimeSpan baseUtcOffset, TimeSpan dstUtcOffset, string displayName, 
                            string daylightName, string id, string standardName, 
                            bool supportsDaylightSavingTime, bool isDaylightSavingTime)
        {
            //if they don't support DST, both baseUtcOffset and dstUtcOffset will be the same value.
            this.BaseUtcOffset = baseUtcOffset;
            this.DSTUtcOffset = dstUtcOffset;
            string disTz = dstUtcOffset.Hours < 0 ? "-" : "+";
            this.DisplayName = $"({disTz}{(isDaylightSavingTime ? dstUtcOffset.ToString(@"hh\:mm") : baseUtcOffset.ToString(@"hh\:mm"))}) {displayName}";
            this.DaylightName = daylightName;
            this.Id = id;
            this.StandardName = standardName;
            this.SupportsDaylightSavingTime = supportsDaylightSavingTime;
            this.IsDaylightSavingTime = isDaylightSavingTime;
        }

        /// <summary>
        /// Off set from UTC Time during, not DST.
        /// </summary>
        public TimeSpan BaseUtcOffset { get; }
        /// <summary>
        /// DST off set from UTC Time during.
        /// </summary>
        public TimeSpan DSTUtcOffset { get; }
        /// <summary>
        /// Auto corrected based on DST or not.
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// DST Name
        /// </summary>
        public string DaylightName { get; }
        /// <summary>
        /// Raw name for Timezone
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Base name, when not in DST.
        /// </summary>
        public string StandardName { get; }
        /// <summary>
        /// If this Timezone supports DST.
        /// </summary>
        public bool SupportsDaylightSavingTime { get; }
        /// <summary>
        /// If currently in DST.
        /// </summary>
        public bool IsDaylightSavingTime { get; }
    }
}
