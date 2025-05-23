﻿using Microsoft.EntityFrameworkCore;
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
            builder.Entity<PageTemplate>()
                .HasMany(x => x.Pages)
                .WithOne(x => x.Template);

            builder.Entity<Profile>()
                .HasMany(x => x.SocialMediaAccounts)
                .WithOne(x => x.Profile)
                .IsRequired();
            builder.Entity<Profile>()
                .HasOne(x => x.PrimaryContact);

            //builder.Entity<Profile>()
            //    .HasOne(x => x.PrimaryContact);
        }

        private readonly Guid DEFAULT_TEMPLATE = Guid.Parse("B033C355-D1EA-445C-904F-B3081DBB834F");
        private readonly Guid HOME_PAGE = Guid.Parse("D3380285-4739-444B-88DB-6699AFF1389D");
        private readonly Guid CONTACT_ID = Guid.Parse("3AE4C685-24E2-40B1-B96B-9772DDAA3602");
        private readonly Guid PROFILE_ID = Guid.Parse("182733E1-C680-4633-B262-059CD75CD050");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSeeding((context, _) => {
                bool changed = false;
                PageTemplate? template = context.Set<PageTemplate>()
                    .FirstOrDefault(x => x.Id == DEFAULT_TEMPLATE);
                Profile? profile = context.Set<Profile>()
                    .FirstOrDefault(x => x.Id == PROFILE_ID);

                if (profile == null) {
                    changed = true;
                    Contact contact = new() {
                        Id = CONTACT_ID,
                        Email = "jon.testington@example.com",
                        FamilyName = "Testington",
                        GivenName = "Jon",
                        Title = "Consultant",
                    };
                    contact.InitliazeSingleEntityIds();

                    profile = new() {
                        Id = PROFILE_ID,
                        Name = "Default Profile",
                        PrimaryContact = contact,
                    };
                    profile.InitliazeSingleEntityIds();
                    context.Set<Profile>().Add(profile);
                }

                if (template == null) {
                    changed = true;
                    template = new() {
                        Id = DEFAULT_TEMPLATE,
                    };
                    template.InitliazeSingleEntityIds();
                    template.InjectedContent.Add(new InjectedContent() {
                        Contents = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css",
                        Location = ContentLocations.Head,
                        Name = "Bootstrap Styles",
                        Source = ContentSources.Url,
                        Type = ContentTypes.StyleSheet,
                    });
                    template.InjectedContent.Add(new InjectedContent() {
                        Contents = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js",
                        Location = ContentLocations.Head,
                        Name = "Bootstrap Scripts",
                        Source = ContentSources.Url,
                        Type = ContentTypes.Script,
                    });
                    context.Set<PageTemplate>().Add(template);

                    Page page = new() {
                        Id = HOME_PAGE,
                        Name = "Home Page",
                        Type = PageTypes.Homepage,
                        Template = template,
                    };
                    page.InitliazeSingleEntityIds();
                    page.Metadata.Title = "My New Home Page";
                    page.Metadata.Description = "Welcome to my new homepage.";
                    page.Metadata.Keywords = "Jason Iverson, jason-iverson.com";
                    context.Set<Page>().Add(page);
                }

                if (changed)
                    context.SaveChanges();

            });
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<InjectedContent> InjectedContents { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<PageTemplate> PageTemplates { get; set; }

        public DbSet<PageMetadata> PageMetadatas { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }

    }

}
