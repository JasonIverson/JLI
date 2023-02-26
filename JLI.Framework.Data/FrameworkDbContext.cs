using Microsoft.AspNetCore.Identity;
using EFCore = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JLI.Framework.Data {

    public class FrameworkDbContext<TUser,
        TIdentityRole,
        TKey,
        TIdentityUserClaim,
        TIdentityUserRole,
        TIdentityUserLogin,
        TIdentityRoleClaim,
        TIdentityUserToken>
        : EFCore.IdentityDbContext<TUser,
            TIdentityRole,
            TKey,
            TIdentityUserClaim,
            TIdentityUserRole,
            TIdentityUserLogin,
            TIdentityRoleClaim,
            TIdentityUserToken>
        where TKey : IEquatable<TKey>
        where TUser : IdentityUser<TKey>
        where TIdentityRole : IdentityRole<TKey>
        where TIdentityUserClaim: IdentityUserClaim<TKey>
        where TIdentityUserRole : IdentityUserRole<TKey>
        where TIdentityUserLogin : IdentityUserLogin<TKey>
        where TIdentityRoleClaim: IdentityRoleClaim<TKey>
        where TIdentityUserToken : IdentityUserToken<TKey> {

        public FrameworkDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options)
            : base(options) { }

    }

    public class FrameworkDbContext<TKey> : FrameworkDbContext<
        IdentityUser<TKey>,
        IdentityRole<TKey>,
        TKey,
        IdentityUserClaim<TKey>,
        IdentityUserRole<TKey>,
        IdentityUserLogin<TKey>,
        IdentityRoleClaim<TKey>,
        IdentityUserToken<TKey>> 
        where TKey : IEquatable<TKey> {

        public FrameworkDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options)
            : base(options) { }

    }

    public class FrameworkDbContext : FrameworkDbContext<Guid> {

        public FrameworkDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options)
            : base(options) { }

    }
}
