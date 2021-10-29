using System.Collections.Generic;
namespace SearchFoodPetStore.Models
{
    class User
    {
        private int id_user;
        private string name;
        private string emailUser;
        private string location;
        private List<Pet> listPets;
        private List<Evaluation> evaluations;

        public User(int id_User, string name, string emailUser, string location, List<Pet> listPets)
        {
            this.id_user = id_User;
            this.name = name;
            this.emailUser = emailUser;
            this.location = location;
            this.listPets = listPets;
        }
    }
}


