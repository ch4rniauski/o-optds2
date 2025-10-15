namespace laba3.Models.Roles
{
    public abstract class Role
    {
        private string _name => GetType().Name;
    }
}
