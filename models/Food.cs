using System.Collections.Generic;

namespace SearchFoodPetStore.Models
{
    public enum foodKind
    {
        natural = 1,
        noncereals = 2,
        nongluten = 3,
        withprotein = 4
    };
    public enum foodtaste
    {
        salmon = 1,
        tuna = 2,
        chicken = 3,
        pork = 4
    };
    class Food
    {
        private int id_food;
        private string name;
        private string brand;
        private petBreedSize size;
        private string description;
        private string image;
        private foodKind kind;
        private petSpecies specie;
        private foodtaste taste;
        private List<Food_Store> stores;
        private List<Evaluation> evaluations;

        public Food(int id_food, string name, string brand, petBreedSize size, string description, string image, foodKind kind, petSpecies specie, foodtaste taste, List<Food_Store> stores)
        {
            this.id_food = id_food;
            this.name = name;
            this.brand = brand;
            this.size = size;
            this.description = description;
            this.image = image;
            this.kind = kind;
            this.specie = specie;
            this.taste = taste;
            this.stores = stores;
        }


    }
}


