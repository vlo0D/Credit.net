using System.Data.Entity;
namespace CreditBL.Model
{
    public class CreditContext:DbContext
    {
        public CreditContext() : base("CreditConnection")
        {
            Database.SetInitializer<CreditContext>(new DropCreateDatabaseIfModelChanges<CreditContext>());
        }

        public DbSet <Client> Clients { get; set; }
        public DbSet <Credit> Credits { get; set; }
        public DbSet <Employee> Employees { get; set; }
        public DbSet <Type_of_credit> Type_Of_Credits { get; set; }
        public DbSet <Status> Status { get; set; }
        public DbSet <FakeCredit> FakeCredits { get; set; }

    }
}
