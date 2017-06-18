namespace PracticalLinq
{
    using System;

    public class Invoice
    {
        public int InvoiceId { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateTime { get; set; }

        public bool? IsPaid { get; set; }
    }
}
