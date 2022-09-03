namespace SearchFoodForPet.Models
{
    public enum PetBreedSize
    {
        Small = 1,
        Medium = 2,
        Large = 3
    };
    public enum PetAge
    {
        Puppy = 1,
        Junior = 2,
        Senior = 3
    };
    public enum PetSex
    {
        Male = 1,
        Feminine = 2
    };
    public enum PetActivityLevel
    {
        High = 1,
        Medium = 2,
        Low = 3
    };

    public enum PetHealthCondition
    {
        Allergy = 1,
        WeightControl = 2,
        Digestive = 3,
        Sterilized = 4,
        Urinary = 5,
        HairAndSkin = 6,
        JointReinforcement = 7,
        Healthy = 8
    }

    public class PetModel
    {
        public Guid IdPet { get; set; }
        public Guid IdUser { get; set; }
        public double Weight { get; set; }
        public PetAge Age { get; set; }
        public PetBreedSize Size { get; set; }
        public PetSex Sex { get; set; }
        public PetActivityLevel Activity { get; set; }
        public List<PetHealthCondition> HealthCondition { get; set; }

        public PetModel(Guid idPet, Guid idUser, double weight, PetAge age, PetBreedSize size, PetSex sex, PetActivityLevel activity, List<PetHealthCondition> conditions)
        {
            IdPet = idPet;
            IdUser = idUser;
            Weight = weight;
            Age = age;
            Size = size;
            Sex = sex;
            Activity = activity;
            HealthCondition = conditions;
        }

        public PetModel() { }
    }
}
