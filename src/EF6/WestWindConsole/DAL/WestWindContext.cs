using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.Entities;

namespace WestWindConsole.DAL
{
    public class WestWindContext : DbContext
    {
        //My Database context class is a "virtual representation"
        // of the database, with each DbSet<T> properly referencing 
        // a particular table in the database.
        //It inherits from the DbContext class. 
        public WestWindContext() : base("name=WWdb")
        {
            // TODO: Demonstrate null database initializer
            //Tells EF that it should NOT create any table in the datbase on my behalf, (null == no initializer)
            //This is an example of a disabling database initialization programmatically.
            Database.SetInitializer<WestWindContext>(null);
            //An alternative to this would be to disable database initialization in the .config file.
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        // TODO: Practice - Add entities and DbSet<> properties for the remaining tables
    }
}
