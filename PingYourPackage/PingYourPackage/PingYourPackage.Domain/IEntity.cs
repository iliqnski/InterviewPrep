namespace PingYourPackage.Domain
{
    using System;

    public interface IEntity
    {
        Guid Key { get; set; }
    }
}
