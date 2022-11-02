using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Items;
using MAS_WinFormsApp.Models.Order;
using MAS_WinFormsApp.Models.Persons;
using MAS_WinFormsApp.Models.Persons.Customers;
using MAS_WinFormsApp.Models.Persons.Employees;
using MAS_WinFormsApp.Models.Warehouses;
using System.Data.Entity;

namespace MAS_WinFormsApp.Services
{
    public class EShopContext : DbContext
    {

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Deliveryman> Deliverymen { get; set; }
        public virtual DbSet<Packer> Packers { get; set; }
        public virtual DbSet<WarehouseWorker> WarehouseWorkers { get; set; }
        public virtual DbSet<PackerWarehouseWorker> PackerWarehouseWorkers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public virtual DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        //public virtual DbSet<Keyboard> Keyboards { get; set; }
        //public virtual DbSet<Models.Items.Monitor> Monitors { get; set; }
        //public virtual DbSet<ComputerTower> ComputerTowers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehouseItem> WarehouseItems { get; set; }
        public virtual DbSet<CustomerOrder> Orders { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }

        public EShopContext() : base("EShopDB")
        {
            System.Data.Entity.Database.SetInitializer<EShopContext>(new EShopDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>()
                .HasOptional(x => x.IndividualCustomer)
                .WithRequired(x => x.Person);
        }
    }
}
