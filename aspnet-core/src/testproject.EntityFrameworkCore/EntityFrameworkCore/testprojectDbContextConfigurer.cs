using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace testproject.EntityFrameworkCore
{
    public static class testprojectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<testprojectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<testprojectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
