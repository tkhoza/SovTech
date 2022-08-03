using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SovTech.EntityFrameworkCore
{
    public static class SovTechDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SovTechDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SovTechDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
