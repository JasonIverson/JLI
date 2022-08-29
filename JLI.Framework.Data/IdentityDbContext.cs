﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using EFCore = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JLI.Framework.Data {

    public class IdentityDbContext<TKey> : EFCore.IdentityDbContext<
        IdentityUser<TKey>,
        IdentityRole<TKey>,
        TKey,
        IdentityUserClaim<TKey>,
        IdentityUserRole<TKey>,
        IdentityUserLogin<TKey>,
        IdentityRoleClaim<TKey>,
        IdentityUserToken<TKey>> 
        where TKey : IEquatable<TKey> {
    }

    public class IdentityDbContext : IdentityDbContext<Guid> {
    }
}
