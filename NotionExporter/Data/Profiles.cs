using NotionExporter.Data.Models;
using NotionExporter.Data.Settings;

namespace NotionExporter.Data
{
    internal static class Profiles
    {
        public static readonly List<Profile> BuiltInProfiles = new()
        {
            new Profile("Default") { BuiltIn = true }
        };

        public static Profile? GetBuiltInProfile(string profileName)
        {
            return BuiltInProfiles.Find(profile => profile.Name == profileName);
        }

        public static Profile? GetUserProfile(string profileName)
        {
            return SettingsManager.Settings.Profiles.Find(profile => profile.Name == profileName);
        }

        public static Profile? GetProfile(string profileName) =>
            GetBuiltInProfile(profileName) ?? GetUserProfile(profileName);

        public static Profile GetDefaultProfile()
        {
            var name = SettingsManager.Settings.DefaultProfile;
            return GetProfile(name) ?? BuiltInProfiles[0];
        }
    }
}