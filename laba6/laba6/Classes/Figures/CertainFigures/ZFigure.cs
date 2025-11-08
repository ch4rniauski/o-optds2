namespace laba6.Classes.Figures.CertainFigures
{
    public class ZFigure : TetrisFigure
    {
        public override string GetName()
            => "Z-фигура";

        public override bool IsSuperFigure()
            => false;

        public override Color GetColor()
            => Color.Red;

        public override List<Point> GetBlocks() =>
        [
            new Point(0, 0),
            new Point(1, 0),
            new Point(1, 1),
            new Point(2, 1)
        ];
    }
}
