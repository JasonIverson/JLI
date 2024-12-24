using Microsoft.EntityFrameworkCore;
using WebApp.Models.Common;

namespace WebApp.Models {

    public class DbContext : JLI.Framework.Data.FrameworkDbContext {
        public DbContext(DbContextOptions options)
            : base(options) {
        }

        // public DbSet<Address> Addresses { get; set; }

    }

}
