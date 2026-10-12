using WebApplication1_vs2026_2.Models;

namespace WebApplication1_vs2026_2.Repository
{
    public class RepositoryTax
    {

        public List<Tax> ListTaxes = new List<Tax>
        {

                new Tax() { Taxrate = 0.21f, Taxcountry = "Spain" },
                new Tax() { Taxrate = 0.19f, Taxcountry = "Germany" },
                new Tax() { Taxrate = 0.20f, Taxcountry = "France" },
                new Tax() { Taxrate = 0.22f, Taxcountry = "Italy" },
                new Tax() { Taxrate = 0.18f, Taxcountry = "Portugal" }

        };


        public float GetTaxRate(string country)
        {
            var tax = ListTaxes.FirstOrDefault(t => t.Taxcountry == country);
            if (tax != null)
            {
                return tax.Taxrate;
            }
            else
            {
                return 0.0f; // Return 0 if the country is not found
            }
        }

        public List<Tax> GetAllTaxes()
        {
            return ListTaxes;
        }

    }
}
