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

        [Route("recomendations")]
     
        [Route("predictions")]
       
    }
}
