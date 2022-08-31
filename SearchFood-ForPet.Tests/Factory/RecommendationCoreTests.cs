using SearchFoodForPet.Factory;
using Xunit;

namespace SearchFoodForPet.Tests.Factory
{
    public class RecommendationCoreTests
    {
        private readonly RecommendationCore _recommendationObject = new RecommendationCore();
        
        [Fact]
        public void GivenANewPetAndATrainingData_WhenExecuting_RecommendFood_ThenReturnsThePredictedFood()
        {
            //arrange
            double[] newPet = new double[] { 30, 2, 2, 2 };
            double[][] trainingData = new double[2][];
            trainingData[0] = new double[] { 30, 1, 2, 1, 1 };
            trainingData[1] = new double[] { 25, 2, 1, 1, 1 };
            int numClasses = 10;
            int k = 2;
            var expected = 1;

            //act
            var actual = _recommendationObject.RecommendFood(newPet, trainingData, numClasses, k);

            //assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void GivenANewPetAndATrainingData_WhenExecuting_Distance_ThenReturnsTheDistance()
        {
            //arrange
            double[] newPet = new double[] { 30,2,2,2};
            double[] data = new double[] { 25,2,2,2};
            
            var expected = 5; //Calculated Euclidean distance between two arrays(newpet and data)
            //act
            var actual = _recommendationObject.Distance(newPet, data);

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void GivenValidValues_WhenExecuting_Vote_ThenReturnsTheVote()
        {
            //arrange
            IndexAndDistance newObject = new IndexAndDistance(1, 14);
            
            IndexAndDistance[] info = new IndexAndDistance[]{newObject};
            
            double[][] trainingData = new double[2][];
            trainingData[0] = new double[] { 30, 1, 2, 1 , 1 };
            trainingData[1] = new double[] { 25, 2, 1, 1, 1 };
            int numClasses = 10;
            int k = 1;
            var expected = 1;

            //act
            var actual = _recommendationObject.Vote(info, trainingData, numClasses, k);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}