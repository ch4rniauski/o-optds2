using laba3.Models.Permissions;
using laba3.Models.Roles;
using System.Reflection;

namespace laba3.Forms
{
    public partial class SetUpRolePermissionsForm : Form
    {
        private readonly Action<Form> _addFormToPanel;

        public SetUpRolePermissionsForm(Action<Form> addFormToPanel)
        {
            InitializeComponent();

            _addFormToPanel = addFormToPanel;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();

            var startForm = new StartForm(_addFormToPanel);

            _addFormToPanel(startForm);
        }

        private void SetUpRolePermissionsForm_Load(object sender, EventArgs e)
        {
            SwitchRoleCriteriasStatus(true);
            DisplayAllRolesInListBox();
        }

        private void SwitchRoleCriteriasStatus(bool isEnabled)
        {
            ChangeDataPermissionCheckBox.Enabled = isEnabled;
            DeketeUserPermissionCheckBox.Enabled = isEnabled;
            ViewingDataPermissionCheckBox.Enabled = isEnabled;

            if (isEnabled)
            {
                RolePermissionsLabel.Show();
            }
            else
            {
                RolePermissionsLabel.Hide();
            }
        }

        private void DisplayAllRolesInListBox()
        {
            var roles = GetAllRoles();

            PermissionsListBox.DataSource = null;

            PermissionsListBox.DataSource = roles;
            PermissionsListBox.DisplayMember = "Name";
        }

        private List<Type> GetAllRoles()
        {
            var assembly = Assembly.GetAssembly(typeof(Role));

            if (assembly is null)
            {
                return [];
            }

            var types = assembly.GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(Role)))
                .ToList();

            return types;
        }

        private void PermissionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PermissionsListBox.SelectedItem is Type selectedType)
            {
                if (selectedType == typeof(CommonUserRole))
                {
                    ChangeDataPermissionCheckBox.Checked = CommonUserRole.Permissions
                        .OfType<ChangeDataPermission>()
                        .Any(p => p.IsChangesAllowed);

                    ViewingDataPermissionCheckBox.Checked = CommonUserRole.Permissions
                        .OfType<ViewDataPermission>()
                        .Any(p => p.IsViewingAllowed);

                    DeketeUserPermissionCheckBox.Checked = CommonUserRole.Permissions
                        .OfType<DeleteUserPermission>()
                        .Any(p => p.IsRemovalAllowed);
                }
                else if (selectedType == typeof(UserManagerRole))
                {
                    ChangeDataPermissionCheckBox.Checked = UserManagerRole.Permissions
                        .OfType<ChangeDataPermission>()
                        .Any(p => p.IsChangesAllowed);

                    ViewingDataPermissionCheckBox.Checked = UserManagerRole.Permissions
                        .OfType<ViewDataPermission>()
                        .Any(p => p.IsViewingAllowed);

                    DeketeUserPermissionCheckBox.Checked = UserManagerRole.Permissions
                        .OfType<DeleteUserPermission>()
                        .Any(p => p.IsRemovalAllowed);
                }
            }
        }

        private void PermissionCheckBox_Changed(object sender)
        {
            if (PermissionsListBox.SelectedItem is Type selectedType && sender is CheckBox checkBox)
            {
                var permissions = selectedType switch
                {
                    Type t when t == typeof(CommonUserRole) => CommonUserRole.Permissions,
                    Type t when t == typeof(UserManagerRole) => UserManagerRole.Permissions,
                    _ => null
                };

                if (permissions == null)
                {
                    return;
                }

                if (checkBox == ChangeDataPermissionCheckBox)
                {
                    var perm = permissions
                        .OfType<ChangeDataPermission>()
                        .FirstOrDefault();

                    if (perm != null)
                    {
                        perm.IsChangesAllowed = checkBox.Checked;
                    }
                }
                else if (checkBox == ViewingDataPermissionCheckBox)
                {
                    var perm = permissions
                        .OfType<ViewDataPermission>()
                        .FirstOrDefault();

                    if (perm != null)
                    {
                        perm.IsViewingAllowed = checkBox.Checked;
                    }
                }
                else if (checkBox == DeketeUserPermissionCheckBox)
                {
                    var perm = permissions
                        .OfType<DeleteUserPermission>()
                        .FirstOrDefault();

                    if (perm != null)
                    {
                        perm.IsRemovalAllowed = checkBox.Checked;
                    }
                }
            }
        }

        private void ChangeDataPermissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PermissionCheckBox_Changed(sender);
        }

        private void ViewingDataPermissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PermissionCheckBox_Changed(sender);
        }

        private void DeketeUserPermissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PermissionCheckBox_Changed(sender);
        }
    }
}
