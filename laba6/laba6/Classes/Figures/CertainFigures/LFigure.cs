namespace laba6.Classes.Figures.CertainFigures
{
    public class LFigure : TetrisFigure
    {
        public override string GetName()
            => "L-фигура";

        public override bool IsSuperFigure()
            => false;

        public override Color GetColor()
            => Color.Orange;

        public override List<Point> GetBlocks() =>
        [
            new Point(0, 0),
            new Point(0, 1),
            new Point(0, 2),
            new Point(1, 2)
        ];
    }
}
