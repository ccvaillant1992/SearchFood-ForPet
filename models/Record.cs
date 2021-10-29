using System;

namespace SearchFoodPetStore.Models
{
    class Record
    {
        private int id_record;
        private int id_user;
        private int id_food;
        private int id_store;
        private DateTime date;
        private Opinion opinionFood;

        public Record(int id_record, int id_user, int id_food, int id_store, DateTime date, Opinion opinionFood)
        {
            this.id_record = id_record;
            this.id_user = id_user;
            this.id_food = id_food;
            this.id_store = id_store;
            this.date = date;
            this.opinionFood = opinionFood;
        }
    }
}
