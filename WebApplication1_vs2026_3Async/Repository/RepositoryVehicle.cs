using WebApplication1_vs2026_3Async.Models;

namespace WebApplication1_vs2026_3Async.Repository
{
    public class RepositoryVehicle
    {
        private readonly RepositoryTax _repoTax;
        private readonly RepositoryAccesories _repoAccesories;

        public List<Vehicle> ListVehicles { get; }

        public RepositoryVehicle(RepositoryTax repoTax, RepositoryAccesories repoAccesories)
        {
            _repoTax = repoTax;
            _repoAccesories = repoAccesories;

            ListVehicles = new List<Vehicle>();
        }

        // Initialize vehicles asynchronously (populate accessories and tax rates)
        public async Task InitializeAsync()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle { make = "Toyota", model = "Camry", year = 2020, month = 5, market = "USA", price = 25000, fiscalHorsepower = 15, fuelType = "Gasoline" },
                new Vehicle { make = "Honda", model = "Civic", year = 2019, month = 3, market = "Canada", price = 22000, fiscalHorsepower = 12, fuelType = "Gasoline" },
                new Vehicle { make = "Ford", model = "F-150", year = 2021, month = 8, market = "Spain", price = 35000, fiscalHorsepower = 10, fuelType = "Diesel" },
                new Vehicle { make = "Chevrolet", model = "Malibu", year = 2018, month = 11, market = "Mexico", price = 20000, fiscalHorsepower = 14, fuelType = "Gasoline" },
                new Vehicle { make = "Nissan", model = "Altima", year = 2022, month = 2, market = "USA", price = 28000, fiscalHorsepower = 16, fuelType = "Gasoline" },
                new Vehicle { make = "BMW", model ="3 Series", year =2020, month =7, market ="Spain", price =40000, fiscalHorsepower =20, fuelType ="Gasoline" },
                new Vehicle { make = "BMW", model = "1 Series", year = 2020, month = 7, market = "Spain", price = 40000, fiscalHorsepower = 10, fuelType = "Gasoline" },
                new Vehicle { make = "BMW", model = "3 Series", year = 2020, month = 7, market = "Spain", price = 40000, fiscalHorsepower = 20, fuelType = "Electric" },
            };

            // Populate accessories and tax rate for each vehicle
            foreach (var vehicle in vehicles)
            {
                vehicle.accesories = await _repoAccesories.GetAccesoriesByModelAsync(vehicle.model);
                vehicle.taxRate = await _repoTax.GetTaxRateAsync(vehicle.market);
            }

            ListVehicles.AddRange(vehicles);

            CalculateFinalPrices(ListVehicles);
        }

        public void CalculateAccesoriesPrices(Vehicle vehicle)
        {
            float totalAccesoriesPrice = 0;
            vehicle.pricewithoutTax = vehicle.price;

            foreach (var accesory in vehicle.accesories)
            {
                totalAccesoriesPrice += accesory.Price;
            }
            vehicle.pricewithoutTax += totalAccesoriesPrice;
        }
        public void CalculateFinalPrices (List<Vehicle> Listvehicle)
        {
            foreach (var vehicle in Listvehicle)
            {
                CalculateAccesoriesPrices(vehicle);
                vehicle.priceWithTax = vehicle.pricewithoutTax * (1 + vehicle.taxRate);
            }
        }

        public Task<Vehicle?> GetVehicleByMakeAndModelAsync(string make, string model)
        {
            var vehicle = ListVehicles.FirstOrDefault(v => v.make == make && v.model == model);
            return Task.FromResult(vehicle);
        }

        public Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            return Task.FromResult(ListVehicles);
        }



    }
}
