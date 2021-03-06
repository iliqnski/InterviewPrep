﻿namespace PingYourPackage.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ShipmentState : IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public Guid ShipmentKey { get; set; }

        [Required]
        public ShipmentStatus ShipmentStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public Shipment Shipment { get; set; }
    }
}
