using System.Collections.Generic;

namespace SearchFoodForPet.FunctionApp.Models
{
    public class UserRequestModel
    {
        public string Name { get; set; }
        public string EmailUser { get; set; }
        public string Location { get; set; }
        public List<string> PetNames { get; set; }
    }
}
