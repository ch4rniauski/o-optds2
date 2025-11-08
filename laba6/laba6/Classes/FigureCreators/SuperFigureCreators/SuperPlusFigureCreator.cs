using laba6.Classes.Figures;
using laba6.Classes.Figures.SuperFigures;

namespace laba6.Classes.FigureCreators.SuperFigureCreators
{
    public class SuperPlusFigureCreator : FigureCreator
    {
        public override TetrisFigure CreateFigure()
            => new SuperPlusFigure();
    }
}
