namespace laba3.Models.Permissions
{
    public class ChangeDataPermission : Permission
    {
        public bool IsChangesAllowed { get; set; }

        public ChangeDataPermission(bool isChangesAllowed)
        {
            IsChangesAllowed = isChangesAllowed;
        }
    }
}
