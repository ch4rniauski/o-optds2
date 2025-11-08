namespace laba6.Classes.Figures
{
    public abstract class TetrisFigure
    {
        public abstract string GetName();
        public abstract bool IsSuperFigure();
        public abstract List<Point> GetBlocks();
        public abstract Color GetColor();
    }
}
