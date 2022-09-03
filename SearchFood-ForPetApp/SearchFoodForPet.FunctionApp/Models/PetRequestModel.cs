using System;
using System.Collections.Generic;
using SearchFoodForPet.Models;

namespace SearchFoodForPet.FunctionApp.Models
{
    public class PetRequestModel
    {
        public Guid IdUser { get; set; }
        public double Weight { get; set; }
        public PetAge Age { get; set; }
        public PetBreedSize Size { get; }
        public PetSex Sex { get; }
        public PetActivityLevel Activity { get; set; }
        public List<PetHealthCondition> HealthCondition { get; set; }
    }
}
