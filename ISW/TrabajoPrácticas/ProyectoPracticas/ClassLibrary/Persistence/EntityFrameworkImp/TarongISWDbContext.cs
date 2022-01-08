

using System.Data.Entity;
using TarongISW.Entities;

namespace TarongISW.Persistence
{
    public class TarongISWDbContext : DbContextISW
    {
        public TarongISWDbContext() : base("Name=TarongISWDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static TarongISWDbContext()
        {
            //Database.SetInitializer<VehicleRentalDbContext>(new CreateDatabaseIfNotExists<VehicleRentalDbContext>());
            Database.SetInitializer<TarongISWDbContext>(new DropCreateDatabaseIfModelChanges<TarongISWDbContext>());
            //Database.SetInitializer<VehicleRentalDbContext>(new DropCreateDatabaseAlways<VehicleRentalDbContext>());
            //Database.SetInitializer<VehicleRentalDbContext>(new VehicleRentalDbInitializer());
            //Database.SetInitializer(new NullDatabaseInitializer<VehicleRentalDbContext>());
        }

        //public IDbSet<BranchOffice> BranchOffices { get; set; }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<Crate> crates { get; set; }
        public DbSet<Group> groups  { get; set; }
        public DbSet<Parcel> parcels { get; set; }
        public DbSet<Permanent> permanents { get; set; }
        public DbSet<Person> people { get; set; }
        public DbSet<Temporary> temporaries { get; set; }
        public DbSet<Trip> trips { get; set; }
        public DbSet<Truck> trucks { get; set; }

        //public IDbSet<Reservation> Reservations { get; set; }
        //public IDbSet<Category> Categories { get; set; }
        //public IDbSet<Person> People { get; set; }
        //public IDbSet<Customer> Customers { get; set; }
        //public IDbSet<CreditCard> CreditCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Primary keys with non conventional name
            /*
            modelBuilder.Entity<Person>().HasKey(p => p.Dni);
            modelBuilder.Entity<Customer>().HasKey(c => c.Dni);
            modelBuilder.Entity<CreditCard>().HasKey(c => c.Digits);
            */
            // Classes with more than one relationship
            /*
            modelBuilder.Entity<Reservation>().HasRequired(r => r.PickUpOffice).WithMany(o => o.PickUpReservations).WillCascadeOnDelete(false);
            modelBuilder.Entity<Reservation>().HasRequired(r => r.ReturnOffice).WithMany(o => o.ReturnReservations).WillCascadeOnDelete(false);
            */
        }

    }

}