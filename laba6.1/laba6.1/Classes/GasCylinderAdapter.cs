namespace laba6._1.Classes
{
    public class GasCylinderAdapter : ICylinderInfo
    {
        private readonly GasCylinder _cylinder = new();

        public GasCylinderAdapter()
        {
        }

        public void ModifVolume(double dV)
        {
            _cylinder.Volume += dV;
        }

        public double GetDp(int T0, int T1)
            => _cylinder.GetPressure(T1) - _cylinder.GetPressure(T0);

        public string Passport()
            => _cylinder.ToString();
    }
}
