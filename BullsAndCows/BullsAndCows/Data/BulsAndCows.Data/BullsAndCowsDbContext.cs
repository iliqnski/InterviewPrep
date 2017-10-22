namespace BulsAndCows.Data
{
    using BullsAndCows.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;

    public class BulsAndCowsDbContext : IdentityDbContext<User>
    {
        public BulsAndCowsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BulsAndCowsDbContext Create()
        {
            return new BulsAndCowsDbContext();
        }
    }
}
