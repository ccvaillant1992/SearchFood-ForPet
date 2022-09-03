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
    public class RecommenderManagementFunctionTests
    {
        private Mock<HttpRequest> _mockRequest;
        private readonly Mock<ILogger> _loggerMock;

        public RecommenderManagementFunctionTests()
        {
            _mockRequest = new Mock<HttpRequest>();
            _loggerMock = new Mock<ILogger>();
        }

        [Fact]
        public async Task GivenValidRequest_WhenExecutingGetRecommendations_ThenReturnOkObjectResult()
        {
            //arrange
            string fakeRequest = File.ReadAllText(Path.Combine("Functions", "Fake", "fakeRecommenderRequest.json"));
            byte[] fakeFileBytes = Encoding.UTF8.GetBytes(fakeRequest);
            var fakeMemoryStream = new MemoryStream(fakeFileBytes);
            _mockRequest.Setup(t => t.Body).Returns(fakeMemoryStream);
            var target = new RecommenderManagementFunction();
            //act
            var actual = await target.GetRecommendations(_mockRequest.Object, _loggerMock.Object);

            //assert
            Assert.Equal(200, ((OkObjectResult)actual).StatusCode);
        }
    }
}
