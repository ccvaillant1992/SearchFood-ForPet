using System;
using SearchFood_ForPet.Models;
using SearchFood_ForPet.Controllers;
using Xunit;
using Microsoft.AspNetCore.Http;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SearchFood_ForPet.Tests
{
    public class FoodTests
    {
        private readonly ILogger<SearchFood_ForPetController> loggerMock;
        private readonly SearchFood_ForPetController searchFood_ForPetController;

        public FoodTests()
        {
            this.searchFood_ForPetController = new SearchFood_ForPetController(loggerMock);
        }

        [Fact]
        public void GivenValidRequest_getfoods_WhenExecutesListFoodsVerifyTheTypeOfTheReturnValue()
        {
            //arrange
            List<Food> expected = new List<Food>();

            //act
            var actual = searchFood_ForPetController.ListFoods();

            //assert
            Assert.IsType(expected.GetType(), actual);
        }

        [Fact]
        public void GivenValidRequest_postfoods_WhenExecutesAddFoodsThenReturnOkObject()
        {
            //arrange
            Food newFood = new Food(2, "Royal Canin", "Pacific Stream", petBreedSize.large, "Pienso para perros Royal Canin Maxi Adult", "", foodKind.withprotein, petSpecies.dog, foodtaste.pork);

            //act
            var result = searchFood_ForPetController.AddFoods(newFood);

            // Assert
            Assert.IsType<OkResult>(result as OkResult);
        }



    }
}
