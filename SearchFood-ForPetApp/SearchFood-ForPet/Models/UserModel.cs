namespace SearchFoodForPet.Models
{
    public class UserModel
    {
        public int IdUser { get; }
        public string Name { get; set; }
        public string EmailUser { get; set; }
        public string Location { get; set; }
        public List<PetModel> ListPets { get; set; }

        public UserModel(int idUser, string name, string emailUser, string location, List<PetModel> listPets)
        {
           IdUser = idUser;
           Name = name;
           EmailUser = emailUser;
           Location = location;
           ListPets = listPets;
        }

    }
}
