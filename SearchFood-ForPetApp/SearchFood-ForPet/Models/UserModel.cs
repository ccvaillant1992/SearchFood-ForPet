﻿namespace SearchFoodForPet.Models
{
    public class UserModel
    {
        public Guid IdUser { get; set; }
        public string Name { get; set; }
        public string EmailUser { get; set; }
        public string Location { get; set; }
        public List<string> PetNames { get; set; }
        
    }
}
