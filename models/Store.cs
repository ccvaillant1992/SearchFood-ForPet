using System.Collections.Generic;


namespace SearchFoodPetStore.Models
{
    class Store
    {
        private int id_store;
        private string name;
        private string direction;
        private string city;
        private string phoneNumeber;
        private List<Food_Store> foods;

        public Store(int id_store, string name, string direction, string city, string phoneNumeber, List<Food_Store> listFoods)
        {
            this.id_store = id_store;
            this.name = name;
            this.direction = direction;
            this.city = city;
            this.phoneNumeber = phoneNumeber;
            this.foods = listFoods;
        }
    }
}


