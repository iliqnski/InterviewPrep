namespace ACM.BL
{
    using System;

    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public object ProductId { get; private set; }

        public Decimal? CurrentPrice { get; set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(this.ProductName) || this.CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
