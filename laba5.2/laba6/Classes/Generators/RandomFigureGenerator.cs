using laba6.Classes.FigureCreators;
using laba6.Classes.FigureCreators.CertainFigureCreators;
using laba6.Classes.FigureCreators.SuperFigureCreators;
using laba6.Classes.Figures;

namespace laba6.Classes.Generators
{
    public class RandomFigureGenerator
    {
        private readonly Random random = new();
        private readonly List<FigureCreator> creators =
        [
            new IFigureCreator(),
            new OFigureCreator(),
            new TFigureCreator(),
            new LFigureCreator(),
            new ZFigureCreator(),
            new SuperIFigureCreator(),
            new SuperPlusFigureCreator()
        ];

        public TetrisFigure GenerateRandomFigure()
        {
            var index = random.Next(creators.Count);

            return creators[index].CreateFigure();
        }
    }
}
