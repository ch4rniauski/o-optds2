using laba3.Models.Permissions;

namespace laba3.Models.Roles
{
    public class CommonUserRole : Role
    {
        public static List<Permission> Permissions { get; set; } =
            [
                new DeleteUserPermission(false),
                new ChangeDataPermission(false),
                new ViewDataPermission(false)
            ];
    }
}
