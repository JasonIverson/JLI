using Microsoft.EntityFrameworkCore;
using WebApp.Models.Common;
using WebApp.Models.Profiles;

namespace WebApp.Models {

    public class DbContext : JLI.Framework.Data.FrameworkDbContext {
        public DbContext(DbContextOptions options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Profile>()
                .HasMany(x => x.SocialMediaAccounts)
                .WithOne(x => x.Profile)
                .IsRequired();
        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }

    }

}
