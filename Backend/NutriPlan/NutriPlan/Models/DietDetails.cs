namespace NutriPlan.Models
{
    public class DietDetails
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public virtual Customer Customer { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteDrink { get; set; }
    }
}
