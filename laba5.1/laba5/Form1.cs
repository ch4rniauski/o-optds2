using laba5.Classes.CertainMovieFactory;
using laba5.Classes.Models;
using laba5.Classes.MovieFactory;

namespace laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            comboBoxMovies.Items.AddRange(["Матрица", "Начало", "Интерстеллар", "Бойцовский клуб"]);
            comboBoxMovies.SelectedIndex = 0;

            comboBoxLanguage.Items.AddRange(["Русский", "English", "Deutsch"]);
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void ButtonOrder_Click_1(object sender, EventArgs e)
        {
            MovieFactory factory = comboBoxLanguage.SelectedIndex switch
            {
                0 => new RussianMovieFactory(),
                1 => new EnglishMovieFactory(),
                2 => new GermanMovieFactory(),
                _ => new RussianMovieFactory()
            };

            var movie = new Movie(comboBoxMovies.SelectedItem?.ToString()!, factory);
            textBoxInfo.Text = movie.GetFullInfo();
        }
    }
}
