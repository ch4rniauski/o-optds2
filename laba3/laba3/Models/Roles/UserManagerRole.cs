using laba3.Models.Permissions;

namespace laba3.Models.Roles
{
    public class UserManagerRole : Role
    {
        public static List<Permission> Permissions { get; set; } =
            [
                new DeleteUserPermission(true),
                new ChangeDataPermission(true),
                new ViewDataPermission(true)
            ];
    }
}
