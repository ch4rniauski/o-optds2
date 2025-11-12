using laba6._1.Classes;

namespace laba6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDV.Text, out var dV)
                || !int.TryParse(txtT0.Text, out var T0)
                || !int.TryParse(txtT1.Text, out var T1))
            {
                MessageBox.Show(
                    text: "Введите корректные числовые значения для dV, T0 и T1.",
                    caption: "Ошибка ввода",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);

                return;
            }

            ICylinderInfo target = new GasCylinderAdapter();

            target.ModifVolume(dV);

            var pressureChange = target.GetDp(T0, T1);
            var passport = target.Passport();

            lblPressureChange.Text = $"Изменение давления при изменении температуры с {T0} до {T1}: {pressureChange:F2} Па";
            lblPassport.Text = $"Данные объекта: {passport}";
        }
    }
}
