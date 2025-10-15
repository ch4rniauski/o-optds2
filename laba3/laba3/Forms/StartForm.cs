namespace laba3.Forms
{
    public partial class StartForm : Form
    {
        private readonly Action<Form> _addFormToPanel;

        public StartForm(Action<Form> addFormToPanel)
        {
            InitializeComponent();

            _addFormToPanel = addFormToPanel;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(_addFormToPanel);

            _addFormToPanel(addUserForm);
        }

        private void ViewUserButton_Click(object sender, EventArgs e)
        {
            var viewUserForm = new ViewUserForm(_addFormToPanel);

            _addFormToPanel(viewUserForm);
        }

        private void SetUpRoleRightsButton_Click(object sender, EventArgs e)
        {
            var setUpRolePermissionsForm = new SetUpRolePermissionsForm(_addFormToPanel);

            _addFormToPanel(setUpRolePermissionsForm);
        }
    }
}
