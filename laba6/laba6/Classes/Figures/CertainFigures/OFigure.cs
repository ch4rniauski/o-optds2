namespace laba6.Classes.Figures.CertainFigures
{
    public class OFigure : TetrisFigure
    {
        public override string GetName()
            => "O-фигура (квадрат)";

        public override bool IsSuperFigure()
            => false;

        public override Color GetColor()
            => Color.Yellow;

        public override List<Point> GetBlocks() =>
        [
            new Point(0, 0),
            new Point(1, 0),
            new Point(0, 1),
            new Point(1, 1)
        ];
    }
}
