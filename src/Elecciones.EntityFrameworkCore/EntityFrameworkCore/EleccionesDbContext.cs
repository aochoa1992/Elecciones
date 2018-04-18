using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Elecciones.Authorization.Roles;
using Elecciones.Authorization.Users;
using Elecciones.MultiTenancy;

namespace Elecciones.EntityFrameworkCore
{
    public class EleccionesDbContext : AbpZeroDbContext<Tenant, Role, User, EleccionesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EleccionesDbContext(DbContextOptions<EleccionesDbContext> options)
            : base(options)
        {
        }
    }
}
