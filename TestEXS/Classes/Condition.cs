namespace Installer.Core.Patching
{
    public abstract class Condition
    {
        public abstract bool IsSatified(int buildNumber);
    }
}