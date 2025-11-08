namespace laba6.Classes.Figures.CertainFigures
{
    public class IFigure : TetrisFigure
    {
        public override string GetName()
            => "I-фигура (линия)";

        public override bool IsSuperFigure()
            => false;

        public override Color GetColor()
            => Color.Cyan;

        public override List<Point> GetBlocks() =>
        [
            new Point(0, 0),
            new Point(1, 0),
            new Point(2, 0),
            new Point(3, 0)
        ];
    }
}
