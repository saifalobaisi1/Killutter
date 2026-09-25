namespace Killutter.Modules.Shared
{
    public record Group
    {
        public string Name { get; set; }
        public string DestPath { get; set; }
        public List<string> RecognizedTypes { get; set; }
    }
}
