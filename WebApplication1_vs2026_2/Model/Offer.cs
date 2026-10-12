using WebApplication1_vs2026_2.Model;

namespace WebApplication1_vs2026_2.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public required Vehicle Vehicle { get; set; }
        public required Customer Customer { get; set; }

        public float Discount { get; set; }
        public float FinalPrice { get; set; }
        public float InstallmentAmount { get; set; }
        public float IEMPercentage { get; set; }


    }
}
