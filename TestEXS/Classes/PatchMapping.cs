namespace Installer.Core.Patching
{
    public class PatchMapping
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public TargetPartition TargetPartition { get; set; }
        public Condition Condition { get; set; }
    }
}