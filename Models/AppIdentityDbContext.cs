using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserRoleAdmin.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }
    }
}
