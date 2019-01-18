namespace Installer.Core.Patching
{
    public class FromAndAfter : Condition
    {
        public int Build { get; }

        public FromAndAfter(int build)
        {
            Build = build;
        }

        public override bool IsSatified(int buildNumber)
        {
            return buildNumber >= Build;
        }
    }
}