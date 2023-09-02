using BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        private CustomerDAO() { }
        private static readonly object instanceLock = new object();
        private static CustomerDAO instance = null;
        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        private static readonly byte IS_ACTIVE = 1;
        public Customer CheckLogin(string email, string password)
        {
            try
            {
                var context = new FuflowerBouquetManagementV4Context();
                Customer customer = null;
                customer = context.Customers.Where(cus => cus.CustomerStatus == IS_ACTIVE).
                    FirstOrDefault(cus => cus.Email.Equals(email) && cus.Password.Equals(password));
                return customer;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                List<Customer> customers = null;
                var context = new FuflowerBouquetManagementV4Context();
                customers = context.Customers.ToList();
                return customers;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteACustomer(int customerId)
        {
            try
            {
                var context = new FuflowerBouquetManagementV4Context();
                Customer deletedCustomer = context.Customers.Find(customerId);
                if (deletedCustomer != null)
                {
                    deletedCustomer.CustomerStatus = 0;
                    context.Update(deletedCustomer);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateACustomer(Customer customer)
        {
            try
            {
                var context = new FuflowerBouquetManagementV4Context();
                var email = new EmailAddressAttribute();
                if (string.IsNullOrEmpty(customer.Email)) throw new Exception("Email is required!");
                bool isValid = email.IsValid(customer.Email);
                if (isValid == false) throw new Exception("Invalid email!");
                if (string.IsNullOrEmpty(customer.CustomerName)) throw new Exception("Name is required!");
                if (string.IsNullOrEmpty(customer.City)) throw new Exception("City is required!");
                if (string.IsNullOrEmpty(customer.Country)) throw new Exception("Country is required!");
                context.Customers.Update(customer);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddACustomer(Customer customer)
        {
            try
            {
                var context = new FuflowerBouquetManagementV4Context();
                var email = new EmailAddressAttribute();
                if (customer.CustomerId <= 0) throw new Exception("ID is required!");
                bool checkDuplicate = context.Customers.Any(cus => cus.CustomerId == customer.CustomerId);
                if (checkDuplicate) throw new Exception("Duplicate of ID!");
                if (string.IsNullOrEmpty(customer.Email)) throw new Exception("Email is required!");
                bool isValid = email.IsValid(customer.Email);
                if (isValid == false) throw new Exception("Invalid email!");
                if (string.IsNullOrEmpty(customer.CustomerName)) throw new Exception("Name is required!");
                if (string.IsNullOrEmpty(customer.City)) throw new Exception("City is required!");
                if (string.IsNullOrEmpty(customer.Country)) throw new Exception("Country is required!");
                context.Customers.Add(customer);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
