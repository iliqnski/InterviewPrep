namespace BullsAndCows.Web.Api
{
    using BulsAndCows.Data;
    using BulsAndCows.Data.Migrations;
    using System.Data.Entity;

    public static class DataBaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BulsAndCowsDbContext, Configuration>());
        }
    }
}