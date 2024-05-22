using System.Globalization;

namespace NotionExporter.API
{
    public interface IInstanceInfo
    {
        /// <summary>
        /// True if the current profile is a built-in profile.
        /// </summary>
        /// <returns>If the current profile is a built-in profile</returns>
        public bool IsBuiltInProfile();

        /// <summary>
        /// Returns the current application locale.
        /// </summary>
        /// <returns>The current application locale</returns>
        public CultureInfo CurrentLocale();

        /// <summary>
        /// True if the layout should be right to left, in relation to the current locale.
        /// </summary>
        /// <returns>If the layout is right to left</returns>
        public bool IsRightToLeft();
    }
}