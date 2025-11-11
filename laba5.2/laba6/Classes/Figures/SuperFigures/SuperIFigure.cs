namespace laba6.Classes.Figures.SuperFigures
{
    public class SuperIFigure : TetrisFigure
    {
        public override string GetName()
            => "СУПЕР I-фигура";

        public override bool IsSuperFigure()
            => true;

        public override Color GetColor()
            => Color.LightBlue;

        public override List<Point> GetBlocks() =>
        [
            new Point(0, 0),
            new Point(1, 0),
            new Point(2, 0),
            new Point(3, 0),
            new Point(4, 0),
            new Point(5, 0)
        ];
    }
}
