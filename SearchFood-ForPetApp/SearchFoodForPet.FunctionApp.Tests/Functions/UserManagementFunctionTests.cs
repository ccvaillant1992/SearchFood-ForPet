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
    public class UserManagementFunctionTests
    {
        private Mock<HttpRequest> _mockRequest;
        private readonly Mock<ILogger> _loggerMock;

        public UserManagementFunctionTests()
        {
            _mockRequest = new Mock<HttpRequest>();
            _loggerMock = new Mock<ILogger>();
        }

        [Fact]
        public async Task GivenValidRequest_WhenExecutingAddUsers_ThenReturnOkObjectResult()
        {
            //arrange
            string fakeRequest = File.ReadAllText(Path.Combine("Functions", "Fake", "fakeUserRequest.json"));
            byte[] fakeFileBytes = Encoding.UTF8.GetBytes(fakeRequest);
            var fakeMemoryStream = new MemoryStream(fakeFileBytes);
            _mockRequest.Setup(t => t.Body).Returns(fakeMemoryStream);
            var target = new UserManagementFunction();
            //act
            var actual = await target.AddUsers(_mockRequest.Object, _loggerMock.Object);

            //assert
            Assert.Equal(200, ((OkObjectResult)actual).StatusCode);
        }

        [Fact]
        public async Task GivenValidRequest_WhenExecutingListUsers_ThenReturnOkObjectResult()
        {
            //arrange
            var target = new UserManagementFunction();
            //act
            var actual = await target.ListUsers(_mockRequest.Object, _loggerMock.Object);

            //assert
            Assert.Equal(200, ((OkObjectResult)actual).StatusCode);
        }
    }
}
