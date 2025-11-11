namespace laba6._1.Classes
{
    public class GasCylinder
    {
        public double Volume { get; protected set; }
        public double Mass { get; protected set; }
        public double Molar { get; protected set; }

        public GasCylinder()
        {
            Volume = 1.0; // м3
            Mass = 10.0; // кг
            Molar = 0.029; // кг/моль, например воздух
        }

        public double GetPressure(int temperature)
        {
            // Упрощенная формула давления идеального газа: P = mass * R * T / (Molar * Volume)
            // R = 8.31 (универсальная газовая постоянная), T в Кельвинах, для простоты примем T как целое значение
            var R = 8.31;
            return Mass * R * (temperature + 273) / (Molar * Volume);
        }

        public double AmountOfMatter()
            => Mass / Molar;

        public override string ToString()
            => $"Объем: {Volume:F2} м3, Масса: {Mass:F2} кг, Молярная масса: {Molar:F3} кг/моль";
    }
}
