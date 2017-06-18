namespace ACM.BL
{
    using System.Collections.Generic;

    public class Customer
    {
        public Customer()
            : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            this.AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }

        public static int InstanceCount { get; set; }

        public IEnumerable<Address> AddressList { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return this.LastName + ", " + this.FirstName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(this.LastName)
                || string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
