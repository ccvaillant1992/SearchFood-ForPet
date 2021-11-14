using SearchFood_ForPet.Controllers;
using Xunit;
using Microsoft.Extensions.Logging;


namespace SearchFood_ForPet.Tests
{
    public class PredictionsTests
    {
        private readonly ILogger<SearchFood_ForPetController> loggerMock;
        private readonly SearchFood_ForPetController searchFood_ForPetController;

        [Fact]
        public void GivenValidRequest_predictions_WhenExecutesGetFoodPredictionsThenReturnOkObject()
        {
            //arrange

            //act

            // Assert

        }
    }
}
