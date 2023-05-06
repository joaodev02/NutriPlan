namespace NutriPlan.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int IdDietDetails { get; set; }
        public virtual DietDetails DietDetails { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool Premium { get; set; }
        public string Goal { get; set; }
    }
}
