using System.IO;
using System.Linq;
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
using SearchFoodForPet.Data;
using SearchFoodForPet.Factory;
using SearchFoodForPet.Models;


namespace SearchFoodForPet.FunctionApp.Functions
{
    public class RecommenderManagementFunction
    {
        private TrainingData _rainingData = new TrainingData();

        [FunctionName("GetRecommendations")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Recommendations" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiRequestBody("application/json", typeof(PetModel), Required = false, Description = "")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(FoodModel), Description = "The OK response")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.InternalServerError, Description = "Returned when there is an internal error")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest, Description = "Returned when there is an invalid input")]
        public async Task<IActionResult> GetRecommendations(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "searchfoodapp/recommendations")] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            RecommendationCore _recommendationCore = new RecommendationCore();

            using var reader = new StreamReader(req.Body, encoding: Encoding.UTF8);
            var body = await reader.ReadToEndAsync();
            var petRequest = JsonConvert.DeserializeObject<PetModel>(body);

            int k = 3;
            TrainingData trinData = new TrainingData();
            double[] newPet = new double[] { petRequest.Weight, (int)petRequest.Activity, (int)petRequest.Size, (int)petRequest.Age };
            int numClasses = 10;

            var result = _recommendationCore.RecommendFood(newPet, trinData.LoadData(), numClasses, k);
            var foodRecommended = _rainingData.Foodlists.FirstOrDefault(t => t.IdFood.Equals(result));
            return new OkObjectResult(foodRecommended);
        }
    }
}
