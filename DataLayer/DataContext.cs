using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<OwnerAdd> OwnerAdds { get; set; }
    }
}
