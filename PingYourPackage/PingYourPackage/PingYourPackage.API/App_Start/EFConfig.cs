namespace PingYourPackage.API.App_Start
{
    using PingYourPackage.Domain.Migrations;
    using System;
    using System.Data.Entity.Migrations;

    public class EFConfig
    {
        public static void Initialize()
        {
            RunMigrations();
        }

        private static void RunMigrations()
        {
            var efMigrationSettings = new Configuration();
            var efMigrator = new DbMigrator(efMigrationSettings);
            efMigrator.Update();
        }
    }
}