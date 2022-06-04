using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TrainingAngular.Authorization.Roles;
using TrainingAngular.Authorization.Users;
using TrainingAngular.MultiTenancy;

namespace TrainingAngular.EntityFrameworkCore
{
    public class TrainingAngularDbContext : AbpZeroDbContext<Tenant, Role, User, TrainingAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TrainingAngularDbContext(DbContextOptions<TrainingAngularDbContext> options)
            : base(options)
        {
        }
    }
}
