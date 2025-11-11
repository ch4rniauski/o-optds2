using laba6.Classes.Figures;
using laba6.Classes.Generators;

namespace laba6
{
    public partial class Form1 : Form
    {
        private readonly RandomFigureGenerator generator = new();
        private TetrisFigure currentFigure = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_Click_1(object sender, EventArgs e)
        {
            currentFigure = generator.GenerateRandomFigure();

            labelFigureName.Text = $"Фигура: {currentFigure.GetName()}";
            labelFigureType.Text = currentFigure.IsSuperFigure()
                ? "Тип: СУПЕР-ФИГУРА ⭐"
                : "Тип: Обычная";

            labelFigureType.ForeColor = currentFigure.IsSuperFigure()
                ? Color.Red
                : Color.Blue;

            PanelFigure.Invalidate();
        }

        private void PanelFigure_Paint_1(object sender, PaintEventArgs e)
        {
            if (currentFigure is not null)
            {
                var blockSize = 40;
                var offsetX = 80;
                var offsetY = 80;

                foreach (var block in currentFigure.GetBlocks())
                {
                    var rect = new Rectangle(
                        offsetX + block.X * blockSize,
                        offsetY + block.Y * blockSize,
                        blockSize,
                        blockSize
                    );

                    e.Graphics.FillRectangle(new SolidBrush(currentFigure.GetColor()), rect);
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                }
            }
        }
    }
}
