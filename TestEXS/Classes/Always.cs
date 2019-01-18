namespace Installer.Core.Patching
{
    public class Always : Condition
    {
        public override bool IsSatified(int buildNumber)
        {
            return true;
        }
    }
}