namespace laba6._2.Classes.CertainBodyTypes
{
    public abstract class BodyType
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ActivityLevel { get; set; }

        public BodyType(int height, int weight, int age, string gender, string activityLevel)
        {
            Height = height;
            Weight = weight;
            Age = age;
            Gender = gender;
            ActivityLevel = activityLevel;
        }

        public abstract double CalculateCalories();
    }
}
