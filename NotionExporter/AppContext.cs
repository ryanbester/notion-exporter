using Notion.Client;
using NotionExporter.Data;
using NotionExporter.Data.Models;

namespace NotionExporter
{
    internal static class AppContext
    {
        public static NotionClient NotionClient = NotionClientFactory.Create(new ClientOptions());
        public static Profile CurrentProfile { get; set; } = Profiles.BuiltInProfiles[0];

        public static void SetNotionKey(string notionKey)
        {
            NotionClient = NotionClientFactory.Create(new ClientOptions()
            {
                AuthToken = notionKey
            });
        }
    }
}
