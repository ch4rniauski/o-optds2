namespace laba6._2.Classes.CertainBodyTypes
{
    public class Hypersthenic : BodyType
    {
        public Hypersthenic(int h, int w, int a, string g, string act) : base(h, w, a, g, act) { }

        public override double CalculateCalories()
        {
            var baseCalories = (10 * Weight) + (6.25 * Height) - (5 * Age) + (Gender == "Мужской" ? 5 : -161);

            return AdjustByActivity(baseCalories) * 1.1;
        }

        private double AdjustByActivity(double calories)
        {
            return ActivityLevel switch
            {
                "Низкая" => calories * 1.2,
                "Средняя" => calories * 1.55,
                "Высокая" => calories * 1.9,
                _ => calories
            };
        }
    }
}
