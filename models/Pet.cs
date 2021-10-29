namespace SearchFoodPetStore
{
    public enum petAge
    {
        puppy = 1,
        junior = 2,
        senior = 3
    };
    public enum petBreedSize
    {
        small = 1,
        medium = 2,
        large = 3
    };

    public enum petSpecies
    {
        cat = 1,
        dog = 2
    };

    class Pet
    {
        private int id_pet;
        private int id_user;
        private double weight;
        private petAge age;
        private petBreedSize size;
        private petSpecies specie;

        public Pet(int id_Pet, int id_User, double weight, petAge age, petBreedSize size, petSpecies specie)
        {
            this.id_pet = id_Pet;
            this.id_user = id_User;
            this.weight = weight;
            this.age = age;
            this.size = size;
            this.specie = specie;
        }
    }
}

