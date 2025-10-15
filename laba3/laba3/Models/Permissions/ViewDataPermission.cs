namespace laba3.Models.Permissions
{
    public class ViewDataPermission : Permission
    {
        public bool IsViewingAllowed { get; set; }

        public ViewDataPermission(bool isViewingAllowed)
        {
            IsViewingAllowed = isViewingAllowed;   
        }
    }
}
