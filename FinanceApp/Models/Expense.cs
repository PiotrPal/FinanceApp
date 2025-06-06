using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public double Amount { get; set; }
        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage = "Kwota w niepoprawnym zakresie (0.01)-dużo ")]
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}