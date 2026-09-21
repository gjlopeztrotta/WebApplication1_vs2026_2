using WebApplication1_vs2026_3Async.Models;

namespace WebApplication1_vs2026_3Async.Repository
{
    public class RepositoryOffer
    {
        RepositoryVehicle _repoVehicle;
        RepositoryCustomer _repoCustomer;

        public List<Offer> ListOffers { get; }

        public RepositoryOffer(RepositoryVehicle repoVehicle, RepositoryCustomer repoCustomer)
        {
            _repoVehicle = repoVehicle;
            _repoCustomer = repoCustomer;

            ListOffers = new List<Offer>();
        }

        // Initialize offers asynchronously after repositories are ready
        public async Task InitializeAsync()
        {
            var v1 = await _repoVehicle.GetVehicleByMakeAndModelAsync("Toyota", "Camry");
            var v2 = await _repoVehicle.GetVehicleByMakeAndModelAsync("Honda", "Civic");
            var v3 = await _repoVehicle.GetVehicleByMakeAndModelAsync("Ford", "F-150");
            var v4 = await _repoVehicle.GetVehicleByMakeAndModelAsync("BMW", "3 Series");

            var customer = await _repoCustomer.GetCustomerByNifAsync("12345678A");

            ListOffers.Add(new Offer { Id = 1, Vehicle = v1!, Customer = customer!, Discount = 0.05f, FinalPrice = v1!.priceWithTax * (1 - 0.05f) });
            ListOffers.Add(new Offer { Id = 2, Vehicle = v2!, Customer = customer!, Discount = 0.1f, FinalPrice = v2!.priceWithTax * (1 - 0.1f) });
            ListOffers.Add(new Offer { Id = 3, Vehicle = v3!, Customer = customer!, Discount = 0.15f, FinalPrice = v3!.priceWithTax * (1 - 0.15f) });
            ListOffers.Add(new Offer { Id = 4, Vehicle = v4!, Customer = customer!, Discount = 0.01f, FinalPrice = v4!.priceWithTax * (1 - 0.01f) });
        }

        public Task<List<Offer>> GetAllOffersAsync()
        {
            return Task.FromResult(ListOffers);
        }

        public Task<Offer?> GetOfferByIdAsync(int id)
        {
            var offer = ListOffers.FirstOrDefault(o => o.Id == id);
            return Task.FromResult(offer);
        }
    }
}
