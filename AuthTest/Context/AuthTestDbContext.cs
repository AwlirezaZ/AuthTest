using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthTest.Context
{
    public class AuthTestDbContext : IdentityDbContext

    {
        public AuthTestDbContext(DbContextOptions<AuthTestDbContext> options) : base(options)
        {
            
        }
    }
}
