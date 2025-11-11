using laba6._2.Classes.CertainBodyTypes;

namespace laba6._2.Classes.Facades
{
    public class CalorieFacade
    {
        private BodyType bodyType;

        public CalorieFacade(
            string type,
            int height,
            int weight,
            int age,
            string gender,
            string activityLevel)
        {
            bodyType = type.ToLower() switch
            {
                "астеник" => new Asthenic(height, weight, age, gender, activityLevel),
                "нормостеник" => new Normostenic(height, weight, age, gender, activityLevel),
                "гиперстеник" => new Hypersthenic(height, weight, age, gender, activityLevel),
                _ => throw new ArgumentException("Неверный тип телосложения"),
            };
        }

        public double CalculateDailyCalories()
            => bodyType.CalculateCalories();
    }
}
