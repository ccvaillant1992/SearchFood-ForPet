
namespace SearchFoodPetStore.Models
{
    class Food_Store
    {
        private int id_store;
        private int id_food;
        private double price;

        public Food_Store(int id_store, int id_food, double price)
        {
            this.id_store = id_store;
            this.id_food = id_food;
            this.price = price;
        }
    }
}
