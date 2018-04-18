using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Elecciones.EntityFrameworkCore
{
    public static class EleccionesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EleccionesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EleccionesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
