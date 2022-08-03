using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SovTech.Authorization.Roles;
using SovTech.Authorization.Users;
using SovTech.MultiTenancy;

namespace SovTech.EntityFrameworkCore
{
    public class SovTechDbContext : AbpZeroDbContext<Tenant, Role, User, SovTechDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SovTechDbContext(DbContextOptions<SovTechDbContext> options)
            : base(options)
        {
        }
    }
}
