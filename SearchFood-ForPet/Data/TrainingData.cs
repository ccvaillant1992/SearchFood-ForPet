using SearchFoodForPet.Models;

namespace SearchFoodForPet.Data
{
    public class TrainingData
    {
        //Training Dataset
        public double[][] LoadData()
        {
            double[][] data = new double[10][];
            data[0] = new double[] { pet1.Weight, (int)pet1.Activity, (int)pet1.Size, (int)pet1.Age, food1.IdFood };
            data[1] = new double[] { pet2.Weight, (int)pet2.Activity, (int)pet2.Size, (int)pet2.Age, food9.IdFood };
            data[2] = new double[] { pet3.Weight, (int)pet3.Activity, (int)pet3.Size, (int)pet3.Age, food10.IdFood };
            data[3] = new double[] { pet4.Weight, (int)pet4.Activity, (int)pet4.Size, (int)pet4.Age, food4.IdFood };
            data[4] = new double[] { pet5.Weight, (int)pet5.Activity, (int)pet5.Size, (int)pet5.Age, food2.IdFood };
            data[5] = new double[] { pet6.Weight, (int)pet6.Activity, (int)pet6.Size, (int)pet6.Age, food7.IdFood };
            data[6] = new double[] { pet7.Weight, (int)pet7.Activity, (int)pet7.Size, (int)pet7.Age, food4.IdFood };
            data[7] = new double[] { pet8.Weight, (int)pet8.Activity, (int)pet8.Size, (int)pet8.Age, food8.IdFood };
            data[8] = new double[] { pet9.Weight, (int)pet9.Activity, (int)pet9.Size, (int)pet9.Age, food3.IdFood };
            data[9] = new double[] { pet10.Weight, (int)pet10.Activity, (int)pet10.Size, (int)pet10.Age, food9.IdFood };
            
            return data;
        }

        //List of conditions
        private static List<PetHealthCondition> condition1 = new List<PetHealthCondition>() {PetHealthCondition.Allergy};
        private static List<PetHealthCondition> condition2 = new List<PetHealthCondition>() { PetHealthCondition.Digestive, PetHealthCondition.Sterilized };
        private static List<PetHealthCondition> condition3 = new List<PetHealthCondition>() { PetHealthCondition.Urinary };
        private static List<PetHealthCondition> condition4 = new List<PetHealthCondition>() { PetHealthCondition.WeightControl };
        private static List<PetHealthCondition> condition5 = new List<PetHealthCondition>() { PetHealthCondition.HairAndSkin };
        private static List<PetHealthCondition> condition6 = new List<PetHealthCondition>() { PetHealthCondition.Healthy };
        private static List<PetHealthCondition> condition7 = new List<PetHealthCondition>() { PetHealthCondition.JointReinforcement };

        //Pets
        public  PetModel pet1 = new PetModel(1, 1, 50, PetAge.Junior , PetBreedSize.Medium, PetSex.Feminine, PetActivityLevel.High,condition4 );
        public  PetModel pet2 = new PetModel(2, 2, 30, PetAge.Senior, PetBreedSize.Medium, PetSex.Male, PetActivityLevel.High, condition6);
        public  PetModel pet3 = new PetModel(3, 3, 40, PetAge.Junior, PetBreedSize.Medium, PetSex.Feminine, PetActivityLevel.Low,condition7);
        public  PetModel pet4 = new PetModel(4, 4, 25, PetAge.Puppy, PetBreedSize.Small, PetSex.Feminine, PetActivityLevel.High, condition1);
        public  PetModel pet5 = new PetModel(5, 5, 30, PetAge.Senior, PetBreedSize.Medium, PetSex.Male, PetActivityLevel.Medium, condition2);
        public  PetModel pet6 = new PetModel(6, 6, 35, PetAge.Senior, PetBreedSize.Small, PetSex.Male, PetActivityLevel.Medium, condition3);
        public  PetModel pet7 = new PetModel(7, 7, 20, PetAge.Puppy, PetBreedSize.Small, PetSex.Feminine, PetActivityLevel.High, condition5);
        public  PetModel pet8 = new PetModel(8, 8, 60, PetAge.Senior, PetBreedSize.Large, PetSex.Male, PetActivityLevel.Low, condition4);
        public  PetModel pet9 = new PetModel(9, 9, 30, PetAge.Junior, PetBreedSize.Medium, PetSex.Feminine, PetActivityLevel.Medium, condition1);
        public  PetModel pet10 = new PetModel(10, 10, 40, PetAge.Senior, PetBreedSize.Medium, PetSex.Male, PetActivityLevel.High, condition6);

        //Foods
        public  FoodModel food1 = new FoodModel(1, PetBreedSize.Small, PetHealthCondition.Allergy, DietType.Natural, FoodKind.Dry, FoodTaste.Chicken);
        public  FoodModel food2 = new FoodModel(2, PetBreedSize.Medium, PetHealthCondition.Digestive, DietType.NonCereals, FoodKind.Wet, FoodTaste.Pork);
        public  FoodModel food3 = new FoodModel(3, PetBreedSize.Large, PetHealthCondition.HairAndSkin, DietType.WithProtein, FoodKind.Dry, FoodTaste.Tuna);
        public  FoodModel food4 = new FoodModel(4, PetBreedSize.Small, PetHealthCondition.Healthy, DietType.WithProtein, FoodKind.Homemade, FoodTaste.Vegetable);
        public  FoodModel food5 = new FoodModel(5, PetBreedSize.Medium, PetHealthCondition.JointReinforcement, DietType.WithProtein, FoodKind.Wet, FoodTaste.Chicken);
        public  FoodModel food6 = new FoodModel(6, PetBreedSize.Large, PetHealthCondition.Sterilized, DietType.Natural, FoodKind.Dry, FoodTaste.Pork);
        public  FoodModel food7 = new FoodModel(7, PetBreedSize.Small, PetHealthCondition.Urinary, DietType.Natural, FoodKind.Wet, FoodTaste.Chicken);
        public  FoodModel food8 = new FoodModel(8, PetBreedSize.Medium, PetHealthCondition.WeightControl, DietType.NonGluten, FoodKind.Dry, FoodTaste.Vegetable);
        public  FoodModel food9 = new FoodModel(9, PetBreedSize.Large, PetHealthCondition.Healthy, DietType.Natural, FoodKind.Raw, FoodTaste.Tuna);
        public  FoodModel food10 = new FoodModel(10, PetBreedSize.Small, PetHealthCondition.JointReinforcement, DietType.WithProtein, FoodKind.Dry, FoodTaste.Chicken);
    }
}
