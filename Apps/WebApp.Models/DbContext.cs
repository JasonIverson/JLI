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

            builder.Entity<Page>()
                .HasOne(x => x.Metadata);
            builder.Entity<Page>()
                .HasMany(x => x.InjectedContent)
                .WithMany(x => x.Pages);

            builder.Entity<PageTemplate>()
                .HasMany(x => x.InjectedContent)
                .WithMany(x => x.PageTemplates);

            builder.Entity<Profile>()
                .HasMany(x => x.SocialMediaAccounts)
                .WithOne(x => x.Profile)
                .IsRequired();
        }

        readonly Guid HOME_PAGE = Guid.Parse("D3380285-4739-444B-88DB-6699AFF1389D");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);


            DateTime timestamp = DateTime.Now;
            optionsBuilder.UseSeeding((context, _) => {
                Page? page = context.Set<Page>().FirstOrDefault(x => x.Id == HOME_PAGE);
                if (page == null) {
                    page = new() { 
                        Id = HOME_PAGE,
                        Name = "Home Page",
                        Type = PageTypes.Homepage,
                    };
                    page.InitliazeSingleEntityIds();
                    page.Metadata.Title = "My New Home Page";
                    page.Metadata.Description = "Welcome to my new homepage.";
                    page.Metadata.Keywords = "Jason Iverson, jason-iverson.com";

                    context.Set<Page>().Add(page);
                    context.SaveChanges();
                }
                
            });
        }

        public DbSet<InjectedContent> InjectedContents { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<PageTemplate> PageTemplates { get; set; }

        public DbSet<PageMetadata> PageMetadatas { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }

    }

}
