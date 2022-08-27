using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using EFCore = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JLI.Framework.Data {
    public class IdentityDbContext : EFCore.IdentityDbContext<
        IdentityUser<Guid>, 
        IdentityRole<Guid>, 
        Guid, 
        IdentityUserClaim<Guid>, 
        IdentityUserRole<Guid>, 
        IdentityUserLogin<Guid>, 
        IdentityRoleClaim<Guid>, 
        IdentityUserToken<Guid>> {
    }
}
