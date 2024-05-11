using System.Diagnostics;
using System.Text.Json.Serialization;
using NotionExporter.Core.Settings;

namespace NotionExporter.Models
{
    [DebuggerDisplay("Name = {Name}, Built-In = {BuiltIn}")]
    public class Profile : ICloneable
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonIgnore]
        public bool BuiltIn { get; set; } = false;

        public Profile(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format(BuiltIn ? "{0} [Built-In]" : "{0}", Name);
        }

        public override bool Equals(object? obj)
        {
            return obj is Profile profile &&
                   Name == profile.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        [JsonIgnore]
        public string DisplayString
        {
            get
            {
                var output = ToString();
                if (SettingsManager.Settings.DefaultProfile == Name)
                {
                    output = string.Format("{0} (Default)", output);
                }
                if (Equals(AppContext.CurrentProfile, this))
                {
                    return string.Format("* {0}", output);
                }
                return output;
            }
        }
    }
}
