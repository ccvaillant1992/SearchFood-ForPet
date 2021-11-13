using System;

namespace SearchFood_ForPet.Models
{
    public class Record
    {
        private int id_record;
        private int id_user;
        private int id_food;
        private DateTime date;


        public Record(int id_record, int id_user, int id_food, DateTime date)
        {
            this.id_record = id_record;
            this.id_user = id_user;
            this.id_food = id_food;
            this.date = date;

        }
    }
}
