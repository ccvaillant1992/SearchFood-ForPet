using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using SearchFood_ForPet.Models;


namespace SearchFood_ForPet.Controllers
{
    [ApiController]
    [Route("foods")]
    public class SearchFood_ForPetController : ControllerBase
    {


        private readonly ILogger<SearchFood_ForPetController> _logger;



        public SearchFood_ForPetController(ILogger<SearchFood_ForPetController> logger)
        {
            _logger = logger;

        }

        [HttpGet]
        public List<Food> ListFoods()
        {
            List<Food> foods = new List<Food>();
            Food newFood = new Food(1, "Taste Of The Wild", "Pacific Stream", petBreedSize.medium, "Taste of the Wild Pacific Stream....", "", foodKind.withprotein, petSpecies.dog, foodtaste.salmon);
            foods.Add(newFood);
            return foods;
        }

        [HttpPost]
        public IActionResult AddFoods(Food food)
        {
            List<Food> foods = new List<Food>();
            foods.Add(food);
            return Ok();
        }

        [Route("recomendations")]
        [HttpGet]
        public IActionResult GetFoodRecomendations()
        {

            return Ok();

        }

        [Route("predictions")]
        [HttpGet]
        public IActionResult GetFoodPredictions()
        {

            return Ok();

        }
    }
}
