﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Models.Migrations {
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GivenName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InjectedContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Location = table.Column<byte>(type: "tinyint", nullable: false),
                    Source = table.Column<byte>(type: "tinyint", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Disabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectedContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageMetadatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageMetadatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageTemplateMetadata",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageTemplateMetadata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PrimaryContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Contacts_PrimaryContactId",
                        column: x => x.PrimaryContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MetadataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageTemplates_PageTemplateMetadata_MetadataId",
                        column: x => x.MetadataId,
                        principalTable: "PageTemplateMetadata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Platform = table.Column<byte>(type: "tinyint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMediaAccounts_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjectedContentPageTemplate",
                columns: table => new
                {
                    InjectedContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageTemplatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectedContentPageTemplate", x => new { x.InjectedContentId, x.PageTemplatesId });
                    table.ForeignKey(
                        name: "FK_InjectedContentPageTemplate_InjectedContents_InjectedContentId",
                        column: x => x.InjectedContentId,
                        principalTable: "InjectedContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjectedContentPageTemplate_PageTemplates_PageTemplatesId",
                        column: x => x.PageTemplatesId,
                        principalTable: "PageTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    MetadataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_PageMetadatas_MetadataId",
                        column: x => x.MetadataId,
                        principalTable: "PageMetadatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pages_PageTemplates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "PageTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjectedContentPage",
                columns: table => new
                {
                    InjectedContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectedContentPage", x => new { x.InjectedContentId, x.PagesId });
                    table.ForeignKey(
                        name: "FK_InjectedContentPage_InjectedContents_InjectedContentId",
                        column: x => x.InjectedContentId,
                        principalTable: "InjectedContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjectedContentPage_Pages_PagesId",
                        column: x => x.PagesId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InjectedContentPage_PagesId",
                table: "InjectedContentPage",
                column: "PagesId");

            migrationBuilder.CreateIndex(
                name: "IX_InjectedContentPageTemplate_PageTemplatesId",
                table: "InjectedContentPageTemplate",
                column: "PageTemplatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_MetadataId",
                table: "Pages",
                column: "MetadataId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_TemplateId",
                table: "Pages",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_PageTemplates_MetadataId",
                table: "PageTemplates",
                column: "MetadataId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_PrimaryContactId",
                table: "Profiles",
                column: "PrimaryContactId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaAccounts_ProfileId",
                table: "SocialMediaAccounts",
                column: "ProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "InjectedContentPage");

            migrationBuilder.DropTable(
                name: "InjectedContentPageTemplate");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "InjectedContents");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "PageMetadatas");

            migrationBuilder.DropTable(
                name: "PageTemplates");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "PageTemplateMetadata");
        }
    }
}
