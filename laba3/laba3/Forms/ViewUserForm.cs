using laba3.Models;
using laba3.Models.Roles;
using System.Reflection;

namespace laba3.Forms
{
    public partial class ViewUserForm : Form
    {
        private readonly Action<Form> _addFormToPanel;
        private User? _selectedUser = null;
        private int _counter = 0;

        public ViewUserForm(Action<Form> addFormToPanel)
        {
            InitializeComponent();

            _addFormToPanel = addFormToPanel;
        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            RefreshUsersListBox();
            SwitchSelectedUserDataLabelsVisibility(false);

            ChangeUserRoleComboBox.Hide();

            LoadRolesInComboBox();
        }

        private void RefreshUsersListBox()
        {
            UsersListBox.DataSource = null;

            UsersListBox.DataSource = UserStorage.Users;
            UsersListBox.DisplayMember = "Username";
        }

        private void SwitchSelectedUserDataLabelsVisibility(bool isShowed)
        {
            if (isShowed)
            {
                SelectedUserNameLabel.Show();
                SelectedUserEmailLabel.Show();
                SelectedUserPhoneNumberLabel.Show();
                CurrentUserRoleLabel.Show();
            }
            else
            {
                SelectedUserNameLabel.Hide();
                SelectedUserEmailLabel.Hide();
                SelectedUserPhoneNumberLabel.Hide();
                CurrentUserRoleLabel.Hide();
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();

            var startForm = new StartForm(_addFormToPanel);

            _addFormToPanel(startForm);
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItem is User user)
            {
                UserStorage.RemoveUser(user);

                if (UserStorage.Users.Count == 0)
                {
                    SwitchButtonsStatus(false);
                    ChangeUserRoleComboBox.Hide();
                }

                RefreshUsersListBox();
                SwitchSelectedUserDataLabelsVisibility(false);
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserStorage.Users.Count != 0)
            {
                SwitchButtonsStatus(true);

                if (UsersListBox.SelectedItem is User user)
                {
                    _selectedUser = user;

                    if (_selectedUser.UserRole is not null)
                    {
                        var userRoleType = _selectedUser.UserRole.GetType();

                        ChangeUserRoleComboBox.SelectedItem =
                            ChangeUserRoleComboBox.Items
                            .Cast<Type>()
                            .FirstOrDefault(t => t == userRoleType);
                    }
                }
            }
        }

        private void SwitchButtonsStatus(bool isEnabled)
        {
            ChangeUserDataButton.Enabled = isEnabled;
            ViewUserDataButton.Enabled = isEnabled;
            DeleteUserButton.Enabled = isEnabled;
            ChangeSelectedUserRoleButton.Enabled = isEnabled;
        }

        private void LoadRolesInComboBox()
        {
            var roles = GetAllRoles();

            ChangeUserRoleComboBox.DataSource = null;
            ChangeUserRoleComboBox.DataSource = roles;
            ChangeUserRoleComboBox.DisplayMember = "Name";
            ChangeUserRoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void ViewUserDataButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItem is User user)
            {
                SelectedUserNameLabel.Text = $"Имя: {user.Username}";
                SelectedUserEmailLabel.Text = $"Email: {user.Email}";
                SelectedUserPhoneNumberLabel.Text = $"Номер телефона: {user.PhoneNumber}";

                SwitchSelectedUserDataLabelsVisibility(true);
            }
        }

        private void ChangeUserDataButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItem is User user)
            {
                Close();

                var index = UserStorage.Users.IndexOf(user);

                var addUserForm = new AddUserForm(
                    addFormToPanel: _addFormToPanel,
                    username: user.Username,
                    userEmail: user.Email,
                    userPhoneNumber: user.PhoneNumber,
                    userIndex: index);

                _addFormToPanel(addUserForm);
            }
        }

        private void ChangeSelectedUserRoleButton_Click(object sender, EventArgs e)
        {
            ChangeUserRoleComboBox.Show();

            CurrentUserRoleLabel.Show();
        }

        private void ComboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangeUserRoleComboBox.SelectedItem is Type selectedRoleType)
            {
                var currentRoleInstance = Activator.CreateInstance(selectedRoleType) as Role;

                if (currentRoleInstance is not null
                    && _selectedUser is not null)
                {
                    if (_counter > 1)
                    {
                        _selectedUser.UserRole = currentRoleInstance;
                    }

                    _counter++;

                    CurrentUserRoleLabel.Text = $"Текущая роль: {_selectedUser.UserRole.GetType().Name}";
                }
            }
        }
    }
}
