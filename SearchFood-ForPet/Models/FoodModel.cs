namespace SearchFoodForPet.Models
{
    public enum DietType
    {
        Natural = 1,
        NonCereals = 2,
        NonGluten = 3,
        WithProtein = 4
    };
    public enum FoodKind
    {
        Dry = 1,
        Wet = 2,
        Raw = 3,
        Homemade = 4
    };
    public enum FoodTaste
    {
        Vegetable = 1,
        Tuna = 2,
        Chicken = 3,
        Pork = 4
    };
    public class FoodModel
    {
        public int IdFood { get; }
        public PetBreedSize Size { get; }
        public PetHealthCondition HealthCondition { get; }
        public DietType Diet { get; set; }
        public FoodKind Kind { get; set; }
        public FoodTaste Taste { get; set; }

        public FoodModel(int idFood, PetBreedSize size, PetHealthCondition condition, DietType diet, FoodKind kind, FoodTaste taste)
        {
            IdFood = idFood;
            Size = size;
            HealthCondition = condition;
            Diet = diet;
            Kind = kind;
            Taste = taste;
        }
    }
}
