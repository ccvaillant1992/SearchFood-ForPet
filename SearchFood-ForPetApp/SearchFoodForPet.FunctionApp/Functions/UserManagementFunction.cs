using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using SearchFoodForPet.Models;
using SearchFoodForPet.FunctionApp.Models;

namespace SearchFoodForPet.FunctionApp.Functions
{
    public class UserManagementFunction
    {
        [FunctionName("ListUsers")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Users" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.InternalServerError, Description = "Returned when there is an internal error")]
        public async Task<IActionResult> ListUsers(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "searchfoodapp/user")] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var user1 = new UserModel()
            {
                IdUser = Guid.NewGuid(),
                Name = "Cristina",
                EmailUser = "ccvaillant@gmail.com",
                Location = "",
                PetNames = new List<string>() { "Mazuka", "Kalesy" }
            };
            var user2 = new UserModel()
            {
                IdUser = Guid.NewGuid(),
                Name = "Noel",
                EmailUser = "noel@gmail.com",
                Location = "",
                PetNames = new List<string>() { "Tuko" }
            };
            var users = new List<UserModel>();
            users.Add(user1);
            users.Add(user2);

            return new OkObjectResult(users);
        }

        [FunctionName("AddUsers")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Users" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiRequestBody("application/json", typeof(UserRequestModel), Required = false, Description = "")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.InternalServerError, Description = "Returned when there is an internal error")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest, Description = "Returned when there is an invalid input")]
        public async Task<IActionResult> AddUsers(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "searchfoodapp/user")] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            using var reader = new StreamReader(req.Body, encoding: Encoding.UTF8);
            var body = await reader.ReadToEndAsync();
            var userRequest = JsonConvert.DeserializeObject<UserRequestModel>(body);

            var newUser = new UserModel
            {
                IdUser = Guid.NewGuid(),
                PetNames = userRequest.PetNames,
                EmailUser = userRequest.EmailUser,
                Location = userRequest.Location,
                Name = userRequest.Name

            };
            var users = new List<UserModel> { newUser };

            return new OkObjectResult(users);
        }
    }
}
