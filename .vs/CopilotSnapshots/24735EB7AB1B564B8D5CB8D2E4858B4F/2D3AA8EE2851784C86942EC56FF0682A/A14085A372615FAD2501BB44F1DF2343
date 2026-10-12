using Microsoft.AspNetCore.Http.HttpResults;
using WebApplication1_vs2026_2.Models;

namespace WebApplication1_vs2026_2.Repository
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


            ListVehicles = new List<Vehicle>
        {
                new Vehicle { make = "Toyota", model = "Camry", year = 2020, month = 5, market = "USA", price = 25000, accesories = _repoAccesories.GetAccesoriesByModel("Camry"), fiscalHorsepower = 15, fuelType = "Gasoline", taxRate = _repoTax.GetTaxRate("USA"),  },
                new Vehicle { make = "Honda", model = "Civic", year = 2019, month = 3, market = "Canada", price = 22000, accesories = _repoAccesories.GetAccesoriesByModel("Civic"), fiscalHorsepower = 12, fuelType = "Gasoline", taxRate = _repoTax.GetTaxRate("Canada") },
                new Vehicle { make = "Ford", model = "F-150", year = 2021, month = 8, market = "Spain", price = 35000, accesories = _repoAccesories.GetAccesoriesByModel("F-150"), fiscalHorsepower = 10, fuelType = "Diesel", taxRate = _repoTax.GetTaxRate("Spain") },
                new Vehicle { make = "Chevrolet", model = "Malibu", year = 2018, month = 11, market = "Mexico", price = 20000, accesories = _repoAccesories.GetAccesoriesByModel("Malibu"), fiscalHorsepower = 14, fuelType = "Gasoline", taxRate = _repoTax.GetTaxRate("Mexico") },
                new Vehicle { make = "Nissan", model = "Altima", year = 2022, month = 2, market = "USA", price = 28000, accesories = _repoAccesories.GetAccesoriesByModel("Altima"), fiscalHorsepower = 16, fuelType = "Gasoline", taxRate =_repoTax.GetTaxRate("USA") },
                new Vehicle { make = "BMW", model ="3 Series", year =2020, month =7, market ="Spain", price =40000, accesories =_repoAccesories.GetAccesoriesByModel("3 Series"), fiscalHorsepower =20, fuelType ="Gasoline", taxRate = _repoTax.GetTaxRate("Spain") },
                new Vehicle { make = "BMW", model = "1 Series", year = 2020, month = 7, market = "Spain", price = 40000, accesories = _repoAccesories.GetAccesoriesByModel("1 Series"), fiscalHorsepower = 10, fuelType = "Gasoline", taxRate = _repoTax.GetTaxRate("Spain") },
                new Vehicle { make = "BMW", model = "3 Series", year = 2020, month = 7, market = "Spain", price = 40000, accesories = _repoAccesories.GetAccesoriesByModel("3 Series"), fiscalHorsepower = 20, fuelType = "Electric", taxRate = _repoTax.GetTaxRate("Spain")  },
            };

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

        public Vehicle GetVehicleByMakeAndModel(string make, string model)
        {
            var vehicle = ListVehicles.FirstOrDefault(v => v.make == make && v.model == model);
            if (vehicle != null)
            {
                return vehicle;
            }
            else
            {
                return null;
            }
        }

        public List<Vehicle> GetAllVehicles()
        {
            return ListVehicles;
        }



    }
}
