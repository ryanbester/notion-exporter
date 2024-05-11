using System.Text.Json.Serialization;

namespace NotionExporter.Models
{
    internal class License
    {
        [JsonPropertyName("PackageName")]
        public string Name { get; set; }

        [JsonPropertyName("PackageVersion")]
        public string Version { get; set; }

        [JsonPropertyName("PackageUrl")]
        public string Url { get; set; }

        [JsonPropertyName("Copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("Authors")]
        public List<string> Authors { get; set; }

        [JsonPropertyName("LicenseUrl")]
        public string LicenseUrl { get; set; }

        [JsonPropertyName("Repository")]
        public Repository Repo { get; set; }

        public License(string name, string version, string url, string copyright, List<string> authors, string licenseUrl, Repository repo)
        {
            Name = name;
            Version = version;
            Url = url;
            Copyright = copyright;
            Authors = authors;
            LicenseUrl = licenseUrl;
            Repo = repo;
        }

        public class Repository
        {
            [JsonPropertyName("Url")]
            public string Url { get; set; }

            public Repository(string url)
            {
                Url = url;
            }
        }

    }
}
