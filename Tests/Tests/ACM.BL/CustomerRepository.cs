namespace ACM.BL
{
    using System;
    using System.Collections.Generic;

    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public IList<Customer> Retrieve()
        {
            return new List<Customer>();
        }


        public bool Save()
        {
            return true;
        }
    }
}
