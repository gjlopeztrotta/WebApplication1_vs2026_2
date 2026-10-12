using WebApplication1_vs2026_2.Models;

namespace WebApplication1_vs2026_2.Repository
{
    public class RepositoryCustomer
    {

        public List<Customer> ListCustomers = new List<Customer>
        {
            new Customer { Nif = "12345678A", Name = "John", Surname = "Doe", Email = "john.doe@example.com", Phone = "123456789", Age = 30, Address = "123 Main St" },
            new Customer { Nif = "87654321B", Name = "Jane", Surname = "Smith", Email = "jane.smith@example.com", Phone = "987654321", Age = 25, Address = "456 Oak Ave" },
            new Customer { Nif = "56789089B", Name = "Bob", Surname = "Johnson", Email = "bob.johnson@example.com", Phone = "555123456", Age = 35, Address = "789 Pine Rd" },
            new Customer { Nif = "98765432C", Name = "Alice", Surname = "Williams", Email = "alice.williams@example.com", Phone = "555987654", Age = 28, Address = "321 Elm St" }

        };

        public Customer GetCustomerByNif(string nif)
        {
            var customer = ListCustomers.FirstOrDefault(c => c.Nif == nif);
            if (customer != null)
            {
                return customer;
            }
            else
            {
                return null;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return ListCustomers;
        }
    }
}
