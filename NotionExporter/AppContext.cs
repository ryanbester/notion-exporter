using Notion.Client;
using NotionExporter.Core;
using NotionExporter.Models;

namespace NotionExporter
{
    public static class AppContext
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
