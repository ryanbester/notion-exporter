namespace NotionExporter
{
    internal class NotionItem
    {
        public string Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string LastEditedTime { get; set; }
        public string LastEditedBy { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool Archived { get; set; }
        public string Parent { get; set; }

        public NotionItem(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
