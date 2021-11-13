namespace SearchFood_ForPet.Models
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
    public class Food
    {
        public int id_food { get; }
        public string name { get; set; }
        public string brand { get; set; }
        public petBreedSize size { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public foodKind kind { get; set; }
        public petSpecies specie { get; set; }
        public foodtaste taste { get; set; }

        public Food(int id_food, string name, string brand, petBreedSize size, string description, string image, foodKind kind, petSpecies specie, foodtaste taste)
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
        }
        public Food() { }

    }
}
