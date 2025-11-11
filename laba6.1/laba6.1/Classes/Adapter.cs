namespace laba6._1.Classes
{
    public class Adapter : GasCylinder
    {
        public void ModifVolume(double dV)
        {
            Volume += dV;
        }

        public double GetDp(int T0, int T1)
            => GetPressure(T1) - GetPressure(T0);

        public string Passport()
            => ToString();
    }
}
