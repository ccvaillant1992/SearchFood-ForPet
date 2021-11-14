using SearchFood_ForPet.Controllers;
using Xunit;
using Microsoft.Extensions.Logging;

namespace SearchFood_ForPet.Tests
{
    public class RecomendationsTest
    {
        private readonly ILogger<SearchFood_ForPetController> loggerMock;
        private readonly SearchFood_ForPetController searchFood_ForPetController;

        [Fact]
        public void GivenValidRequest_recomendations_WhenExecutesGetFoodRecomendationsThenReturnOkObject()
        {
            //arrange


            //act

            // Assert

        }
    }
}
