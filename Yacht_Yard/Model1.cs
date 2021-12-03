using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Yacht_Yard
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Accessory> Accessory { get; set; }
        public virtual DbSet<AccToBoats> AccToBoats { get; set; }
        public virtual DbSet<Boat> Boat { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>()
                .Property(e => e.DepositPayed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ContractTotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ContracTotalPrice_inclVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);
        }
    }
}
