using SearchFoodForPet.Data;
using SearchFoodForPet.Factory;
using SearchFoodForPet.Models;

namespace SearchFoodForPet
{
    public class Program
    {
        private static RecommendationCore _obj = new RecommendationCore();
        private static TrainingData _trainingData = new TrainingData();
        public static void Main(string[] args)
        {
            double[][] trainData = _trainingData.LoadData();
            //New Pet registered in the system
            List<PetHealthCondition> condition7 = new List<PetHealthCondition>() { PetHealthCondition.Healthy };
            PetModel pet11 = new PetModel(Guid.NewGuid(), Guid.NewGuid(), 40, PetAge.Puppy, PetBreedSize.Small, PetSex.Male, PetActivityLevel.High, condition7);

            int numClasses = 10;

            double[] newPet = new double[] { pet11.Weight, (int)pet11.Activity, (int)pet11.Size , (int)pet11.Age};
            Console.WriteLine("Classifying food for pet_id: {0} \n", pet11.IdPet);

            int k = 1;
            Console.WriteLine("With k = 1");
            var predicted = _obj.RecommendFood(newPet, trainData, numClasses, k);
            Console.WriteLine("\nPredicted Food = " + predicted);
            Console.WriteLine("");


            Console.WriteLine("Classifying food for pet_id: {0} \n", pet11.IdPet);

            k = 3;
            Console.WriteLine("With k = 3");
            predicted = _obj.RecommendFood(newPet, trainData, numClasses, k);
            Console.WriteLine("\nPredicted Food = " + predicted);
            Console.WriteLine("");

            Console.WriteLine("Classifying food for pet_id: {0} \n", pet11.IdPet);

            k = 5;
            Console.WriteLine("With k = 5");
            predicted = _obj.RecommendFood(newPet, trainData, numClasses, k);
            Console.WriteLine("\nPredicted Food = " + predicted);
            Console.WriteLine("");


            Console.WriteLine("Classifying food for pet_id: {0} \n", pet11.IdPet);

            k = 7;
            Console.WriteLine("With k = 7");
            predicted = _obj.RecommendFood(newPet, trainData, numClasses, k);
            Console.WriteLine("\nPredicted Food = " + predicted);
            Console.WriteLine("");


        }

    }
}

