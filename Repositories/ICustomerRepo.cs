using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepo
    {
        public Customer CheckLogin(string email, string password);

        public List<Customer> GetCustomers();

        public void DeleteACustomer(int customerId);

        public void AddACustomer(Customer customer);

        public void UpdateACustomer(Customer customer);
    }
}
