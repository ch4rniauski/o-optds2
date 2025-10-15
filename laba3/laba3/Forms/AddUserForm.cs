using laba3.Models;
using System.Text.RegularExpressions;

namespace laba3.Forms
{
    public partial class AddUserForm : Form
    {
        private readonly Action<Form> _addFormToPanel;
        private readonly int _userIndex;
        private readonly bool _isAddButNotChange = true;
        private readonly string _username = string.Empty;
        private readonly string _userEmail = string.Empty;
        private readonly string _userPhoneNumber = string.Empty;

        public AddUserForm(Action<Form> addFormToPanel)
        {
            InitializeComponent();

            _addFormToPanel = addFormToPanel;
        }

        public AddUserForm(
            Action<Form> addFormToPanel,
            string username,
            string userEmail,
            string userPhoneNumber,
            int userIndex) : this(addFormToPanel)
        {
            _isAddButNotChange = false;
            _username = username;
            _userEmail = userEmail;
            _userPhoneNumber = userPhoneNumber;
            _userIndex = userIndex;
        }
        
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            EmailErrorLabel.Hide();
            FullNameErrorLabel.Hide();
            PhoneNumberErrorLabel.Hide();

            SetTextIntoTextBoxes();
        }

        private void SetTextIntoTextBoxes()
        {
            FullNameTextBox.Text = _username;
            PhoneNumberTextBox.Text = _userPhoneNumber;
            EmailTextBox.Text = _userEmail;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();

            if (_isAddButNotChange)
            {
                var startForm = new StartForm(_addFormToPanel);

                _addFormToPanel(startForm);
            }
            else
            {
                var viewUserForm = new ViewUserForm(_addFormToPanel);

                _addFormToPanel(viewUserForm);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var isValidData = true;

            var phoneNumber = PhoneNumberTextBox.Text.Trim();
            var email = EmailTextBox.Text.Trim();
            var fullName = FullNameTextBox.Text.Trim();

            if (!IsValidFullName(fullName))
            {
                _ = ShowErrorMessageAsync(FullNameErrorLabel);

                isValidData = false;
            }

            if (!IsValidEmail(email))
            {
                _ = ShowErrorMessageAsync(EmailErrorLabel);

                isValidData = false;
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                _ = ShowErrorMessageAsync(PhoneNumberErrorLabel);

                isValidData = false;
            }

            if (!isValidData)
            {
                return;
            }

            if (_isAddButNotChange)
            {
                var user = new User(fullName, email, phoneNumber);

                UserStorage.AddUser(user);
            }
            else
            {
                UserStorage.ChangeUserInfo(
                    userIndex: _userIndex,
                    userName: fullName,
                    userEmail: email,
                    userPhoneNumber: phoneNumber);
            }

            ClearTextBoxes();
        }

        private async static Task ShowErrorMessageAsync(Label errorLabel)
        {
            errorLabel.Show();

            await Task.Delay(5000);

            errorLabel.Hide();
        }

        private static bool IsValidFullName(string fullName)
            => !string.IsNullOrWhiteSpace(fullName)
                && fullName.Length >= 2
                && fullName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));

        private static bool IsValidEmail(string email)
            => EmailRegex().IsMatch(email);

        private static bool IsValidPhoneNumber(string phone)
            => PhoneRegex().IsMatch(phone);

        private void ClearTextBoxes()
        {
            PhoneNumberTextBox.Clear();
            EmailTextBox.Clear();
            FullNameTextBox.Clear();
        }

        [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        private static partial Regex EmailRegex();

        [GeneratedRegex(@"^\+?[1-9][0-9]{7,14}$")]
        private static partial Regex PhoneRegex();

    }
}
