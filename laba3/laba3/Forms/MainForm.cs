using laba3.Forms;

namespace laba3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var form = new StartForm(AddFormToPanel);

            AddFormToPanel(form);
        }

        private void CloseForm()
            => panel.Controls.Clear();

        private void AddFormToPanel(Form form)
        {
            panel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormClosed += (s, args) => CloseForm();

            panel.Controls.Add(form);

            form.Show();
        }
    }
}
