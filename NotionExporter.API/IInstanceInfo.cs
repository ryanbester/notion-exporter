namespace NotionExporter.API
{
    public interface IInstanceInfo
    {
        /// <summary>
        /// True if the current profile is a built-in profile.
        /// </summary>
        /// <returns>If the current profile is a built-in profile</returns>
        public bool IsBuiltInProfile();
    }
}