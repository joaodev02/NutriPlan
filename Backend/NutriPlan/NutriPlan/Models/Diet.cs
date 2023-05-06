namespace NutriPlan.Models
{
    public class Diet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual Customer Customer { get; set; }
        public string DietPlan { get; set; }
    }
}
