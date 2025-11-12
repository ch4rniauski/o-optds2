namespace laba6._1.Classes
{
    public class GasCylinder
    {
        public double Volume { get; set; }
        public double Mass { get; set; }
        public double Molar { get; set; }

        public GasCylinder()
        {
            Volume = 1.0;   // м3
            Mass = 10.0;    // кг
            Molar = 0.029;  // кг/моль, например воздух
        }

        public double GetPressure(int temperature)
        {
            var R = 8.31;
            return Mass * R * (temperature + 273) / (Molar * Volume);
        }

        public double AmountOfMatter() => Mass / Molar;

        public override string ToString()
            => $"\nОбъем: {Volume:F2} м3\nМасса: {Mass:F2} кг\nМолярная масса: {Molar:F3} кг/моль";
    }
}
