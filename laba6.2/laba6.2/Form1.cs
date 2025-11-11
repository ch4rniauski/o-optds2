using laba6._2.Classes.Facades;

namespace laba6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbBodyType.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            cbActivity.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var type = cbBodyType.SelectedItem!.ToString();
                var height = int.Parse(txtHeight.Text);
                var weight = int.Parse(txtWeight.Text);
                var age = int.Parse(txtAge.Text);
                var gender = cbGender.SelectedItem!.ToString();
                var activity = cbActivity.SelectedItem!.ToString();

                var facade = new CalorieFacade(type!, height, weight, age, gender!, activity!);
                var calories = facade.CalculateDailyCalories();

                lblResult.Text = $"Рекомендуемая норма потребления калорий: {calories:F2} ккал";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: $"Ошибка ввода: {ex.Message}",
                    caption: "Ошибка",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
        }
    }
}
