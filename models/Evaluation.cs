public enum Opinion
{
    verybad = 1,
    bad = 2,
    regular = 3,
    good = 4,
    excellent = 5
};
namespace SearchFoodPetStore.Models
{
    class Evaluation
    {
        private int id_evaluation;
        private int id_food;
        private int id_user;
        private Opinion opinion;

        public Evaluation(int id_evaluation, int id_food, int id_user, Opinion opinion)
        {
            this.id_evaluation = id_evaluation;
            this.id_food = id_food;
            this.id_user = id_user;
            this.opinion = opinion;
        }
    }
}
