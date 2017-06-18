namespace ACM.BL
{
    using System;

    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public object OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            return isValid;
        }
    }
}
