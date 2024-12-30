using Microsoft.EntityFrameworkCore;
using WebApp.Models.Common;
using WebApp.Models.Profiles;
using WebApp.Models.WebContent;
using WebApp.Models.WebContent.Resources;

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

            builder.Entity<Page>()
                .HasOne(x => x.Metadata);
        }

        public DbSet<InjectedContent> InjectedContents { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<PageMetadata> PageMetadatas { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }

    }

}
