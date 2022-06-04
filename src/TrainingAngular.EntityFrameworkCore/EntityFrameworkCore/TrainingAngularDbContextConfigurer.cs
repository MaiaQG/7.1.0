using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TrainingAngular.EntityFrameworkCore
{
    public static class TrainingAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TrainingAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TrainingAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
