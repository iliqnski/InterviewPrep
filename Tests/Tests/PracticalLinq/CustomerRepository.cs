namespace PracticalLinq
{
    using System.Collections.Generic;
    using System.Linq;

    public class CustomerRepository
    {
        public Customer Find(IList<Customer> customerList, int customerId)
        {
            //Customer foundCustomer = null;
            //foreach (var c in customerList)
            //{
            //    if(c.CustomerId == customerId)
            //    {
            //        foundCustomer = c;
            //    }
            //}

            //Linq query syntax
            //var query = from c in customerList
            //             where c.CustomerId == customerId
            //             select c;

            //Linq extension methods
            var query = customerList
                .Where(c => c.CustomerId == customerId);

            return query.FirstOrDefault();
        }

        public IList<Customer> Retrieve()
        {
            IList<Customer> custList = new List<Customer>
            {
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Frodo",
                    LastName = "Baggins",
                    EmailAddress = "fb@hob.me"
                },

                new Customer()
                {
                    CustomerId = 2,
                    FirstName = "Bilbo",
                    LastName = "Baggins",
                    EmailAddress = "bb@hob.me"
                },
                new Customer()
                {
                    CustomerId = 3,
                    FirstName = "Samwise",
                    LastName = "Gangee",
                    EmailAddress = "sg@hob.me"
                },

                new Customer()
                {
                    CustomerId = 4,
                    FirstName = "Rosie",
                    LastName = "Cotton",
                    EmailAddress = "rc@hob.me"
                }
            };

            return custList;
        }

        public IEnumerable<Customer> SortByName(IList<Customer> customerList)
        {
            return customerList
                .OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameReversed(IList<Customer> customerList)
        {
            return customerList
                .OrderByDescending(c => c.LastName)
                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<string> GetNames(IList<Customer> customers)
        {
            var query = customers.Select(c => c.LastName + ", " + c.FirstName);
            return query;
        }

        public dynamic GetNamesAndEmails(IList<Customer> customers)
        {
            var query = customers.Select(c => new
            {
                Name = c.LastName + ", " + c.FirstName,
                c.EmailAddress
            });

            return query;
        }

        public dynamic GetNamesAndTypes(IList<Customer> customers, 
            IList<CustomerType> customerTypes)
        {
            var query = customers.Join(customerTypes,
                c => c.CustomerTypeId,
                ct => ct.CustomerTypeId,
                (c, ct) => new
                {
                    Name = c.LastName + ", " + c.FirstName,
                    CustomerTypeName = ct.TypeName
                });

            return query;
        }
    }
}
