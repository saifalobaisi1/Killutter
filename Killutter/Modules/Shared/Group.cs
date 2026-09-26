namespace Killutter.Modules.Shared
{
    public record Group
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string DestPath { get; set; }
        public List<string> RecognizedTypes { get; set; }

        public Group(string name, string destPath, List<string> recognizedTypes)
        {
            Id = Guid.NewGuid();
            Name = name;
            DestPath = destPath;
            RecognizedTypes = recognizedTypes;
        }
    }
}
