namespace laba6.Classes.Figures.CertainFigures
{
    public class TFigure : TetrisFigure
    {
        public override string GetName()
            => "T-фигура";

        public override bool IsSuperFigure()
            => false;

        public override Color GetColor()
            => Color.Purple;

        public override List<Point> GetBlocks() =>
        [
            new Point(1, 0),
            new Point(0, 1),
            new Point(1, 1),
            new Point(2, 1)
        ];
    }
}
