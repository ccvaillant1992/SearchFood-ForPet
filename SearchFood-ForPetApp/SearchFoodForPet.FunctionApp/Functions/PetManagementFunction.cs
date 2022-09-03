using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;
using SearchFoodForPet.Models;
using SearchFoodForPet.FunctionApp.Models;

namespace SearchFoodForPet.FunctionApp.Functions
{
    public class PetManagementFunction
    {
        
        [FunctionName("AddPets")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Pets" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiRequestBody("application/json", typeof(PetRequestModel), Required = false, Description = "")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(PetModel), Description = "")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.InternalServerError, Description = "Returned when there is an internal error")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest, Description = "Returned when there is an invalid input")]
        public async Task<IActionResult> AddPets(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "searchfoodapp/pet")] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            using var reader = new StreamReader(req.Body, encoding: Encoding.UTF8);
            var body = await reader.ReadToEndAsync();
            var petRequest = JsonConvert.DeserializeObject<PetRequestModel>(body);
            var newPet = new PetModel()
            {
                IdPet = Guid.NewGuid(),
                Weight = petRequest.Weight,
                Age = petRequest.Age,
                Size = petRequest.Size,
                Activity = petRequest.Activity,
                Sex = petRequest.Sex,
                IdUser = petRequest.IdUser,
                HealthCondition = petRequest.HealthCondition

            };
            
            return new OkObjectResult(newPet);
        }
    }
}
