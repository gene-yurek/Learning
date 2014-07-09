namespace EntityFrameworkCodeFirst.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PXMLEntities : DbContext
    {
        // Your context has been configured to use a 'PXMLEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityFrameworkCodeFirst.DataAccess.PXMLEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PXMLEntities' 
        // connection string in the application configuration file.
        public PXMLEntities()
            : base("name=PXMLEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class EquipmentAndSupplyOrder
    {
        public int Id { get; set; }
        public int MessageTrackingId { get; set; }
        public string Name { get; set; }
    }
}