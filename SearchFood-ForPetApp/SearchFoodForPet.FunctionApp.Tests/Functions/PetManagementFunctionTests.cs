using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchFoodForPet.FunctionApp.Functions;

namespace SearchFoodForPet.FunctionApp.Tests.Functions
{
    public class PetManagementFunctionTests
    {
        private Mock<HttpRequest> _mockRequest;
        private readonly Mock<ILogger> _loggerMock;

        public PetManagementFunctionTests()
        {
            _mockRequest = new Mock<HttpRequest>();
            _loggerMock = new Mock<ILogger>();
        }

        [Fact]
        public async Task GivenValidRequest_WhenExecutingAddPets_ThenReturnOkObjectResult()
        {
            //arrange
            string fakeRequest = File.ReadAllText(Path.Combine("Functions", "Fake", "fakePetRequest.json"));
            byte[] fakeFileBytes = Encoding.UTF8.GetBytes(fakeRequest);
            var fakeMemoryStream = new MemoryStream(fakeFileBytes);
            _mockRequest.Setup(t => t.Body).Returns(fakeMemoryStream);
            var target = new PetManagementFunction();
            //act
            var actual = await target.AddPets(_mockRequest.Object, _loggerMock.Object);

            //assert
            Assert.Equal(200, ((OkObjectResult)actual).StatusCode);
        }

    }
}