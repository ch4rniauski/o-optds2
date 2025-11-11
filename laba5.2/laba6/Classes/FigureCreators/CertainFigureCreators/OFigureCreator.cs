using laba6.Classes.Figures;
using laba6.Classes.Figures.CertainFigures;

namespace laba6.Classes.FigureCreators.CertainFigureCreators
{
    public class OFigureCreator : FigureCreator
    {
        public override TetrisFigure CreateFigure()
            => new OFigure();
    }
}
