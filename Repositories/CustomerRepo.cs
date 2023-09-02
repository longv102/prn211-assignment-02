using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        public void AddACustomer(Customer customer) => CustomerDAO.Instance.AddACustomer(customer);

        public Customer CheckLogin(string email, string password) => CustomerDAO.Instance.CheckLogin(email, password);

        public void DeleteACustomer(int customerId) => CustomerDAO.Instance.DeleteACustomer(customerId);

        public List<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomers();

        public void UpdateACustomer(Customer customer) => CustomerDAO.Instance.UpdateACustomer(customer);
    }
}
