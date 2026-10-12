using System.Runtime.InteropServices.Java;

namespace WebApplication1_vs2026_2.Models
{
    public class Vehicle
    {
        public  required string make { get; set; }
        public required string model { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public required string market { get; set; }
        public float price { get; set; }
        public float pricewithoutTax { get; set; }
        public float priceWithTax { get; set; }
        public float taxRate { get; set; }
        public  int fiscalHorsepower { get; set; }
        public required string fuelType { get; set; }
       
        // ✔️ IEM calculado automáticamente
        public float IEM
        {
            get
            {
                if (market == "Spain")
                {
                    if (fuelType == "Electric")
                        return 0f;

                    if (fiscalHorsepower <= 11)
                        return 0.095f;

                    return 0.15f;
                }

                return 0f;
            }
            
        }

        public List<Accesories> accesories { get; set; } = new List<Accesories>();
    }
}

       
