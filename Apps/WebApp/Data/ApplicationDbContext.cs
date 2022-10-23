using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JLI.Framework.Data;
using Microsoft.AspNetCore.Identity;
using WebApp.Data.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : FrameworkDbContext<WebAppUser, 
        IdentityRole<Guid>, 
        Guid, 
        IdentityUserClaim<Guid>, 
        IdentityUserRole<Guid>, 
        IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>,
        IdentityUserToken<Guid>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
