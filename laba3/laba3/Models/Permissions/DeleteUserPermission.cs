namespace laba3.Models.Permissions
{
    public class DeleteUserPermission : Permission
    {
        public bool IsRemovalAllowed { get; set; }

        public DeleteUserPermission(bool isRemovalAllowed)
        {
            IsRemovalAllowed = isRemovalAllowed;
        }
    }
}
