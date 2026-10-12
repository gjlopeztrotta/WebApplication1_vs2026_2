using System.Security.Cryptography.X509Certificates;
using WebApplication1_vs2026_2.Models;

namespace WebApplication1_vs2026_2.Repository
{
    public class RepositoryOffer
    {
        RepositoryVehicle _repoVehicle;
        RepositoryCustomer _repoCustomer;

        RepositoryIEM _repoIEM ;

        public List<Offer> ListOffers { get; }

        public RepositoryOffer(RepositoryVehicle repoVehicle, RepositoryCustomer repoCustomer, RepositoryIEM repoIEM)
        {
            _repoVehicle = repoVehicle;
            _repoCustomer = repoCustomer;
            _repoIEM = repoIEM;

            ListOffers = new List<Offer>
            {
                new Offer { Id = 1, Vehicle = _repoVehicle.GetVehicleByMakeAndModel("Toyota", "Camry"), Customer = _repoCustomer.GetCustomerByNif("12345678A"), Discount = 0.05f, FinalPrice = _repoVehicle.GetVehicleByMakeAndModel("Toyota", "Camry").priceWithTax * (1 - 0.05f) , IEMPercentage = _repoIEM.GetIEMByHorsepower(_repoVehicle.GetVehicleByMakeAndModel("Toyota", "Camry").fiscalHorsepower) },
                new Offer { Id = 2, Vehicle = _repoVehicle.GetVehicleByMakeAndModel("Honda", "Civic"), Customer = _repoCustomer.GetCustomerByNif("12345678A"), Discount = 0.1f, FinalPrice = _repoVehicle.GetVehicleByMakeAndModel("Honda", "Civic").priceWithTax * (1 - 0.1f) , IEMPercentage = _repoIEM.GetIEMByHorsepower(_repoVehicle.GetVehicleByMakeAndModel("Honda", "Civic").fiscalHorsepower) },
                new Offer { Id = 3, Vehicle = _repoVehicle.GetVehicleByMakeAndModel("Ford", "F-150"), Customer = _repoCustomer.GetCustomerByNif("12345678A") , Discount = 0.15f, FinalPrice = _repoVehicle.GetVehicleByMakeAndModel("Ford", "F-150").priceWithTax * (1 - 0.15f) , IEMPercentage = _repoIEM.GetIEMByHorsepower(_repoVehicle.GetVehicleByMakeAndModel("Ford", "F-150").fiscalHorsepower) },
                new Offer { Id = 4, Vehicle = _repoVehicle.GetVehicleByMakeAndModel("BMW", "3 Series"), Customer = _repoCustomer.GetCustomerByNif("12345678A"), Discount=0.01f, FinalPrice = _repoVehicle.GetVehicleByMakeAndModel("BMW", "3 Series").priceWithTax * (1 - 0.01f) , IEMPercentage = _repoIEM.GetIEMByHorsepower(_repoVehicle.GetVehicleByMakeAndModel("BMW", "3 Series").fiscalHorsepower) },
            };



        }

        public List<Offer> GetAllOffers()
        {
            return ListOffers;

        }

        public Offer GetOfferById(int id)
        {
            return ListOffers.FirstOrDefault(o => o.Id == id);

        }
    }
}
