using System.Security.Principal;

namespace Model.Helpers
{
    public static class UserHelper
    {
        public static string GetCurrentUser()
        {
            return WindowsIdentity.GetCurrent().Name;
        }
    }
}
