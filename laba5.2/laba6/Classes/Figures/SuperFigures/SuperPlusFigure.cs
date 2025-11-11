namespace laba6.Classes.Figures.SuperFigures
{
    public class SuperPlusFigure : TetrisFigure
    {
        public override string GetName()
            => "СУПЕР Плюс-фигура";

        public override bool IsSuperFigure()
            => true;

        public override Color GetColor()
            => Color.LimeGreen;

        public override List<Point> GetBlocks() =>
        [
            new Point(1, 0),
            new Point(0, 1),
            new Point(1, 1),
            new Point(2, 1),
            new Point(1, 2)
        ];
    }
}
