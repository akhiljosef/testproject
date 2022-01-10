using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using testproject.Authorization.Roles;
using testproject.Authorization.Users;
using testproject.MultiTenancy;

namespace testproject.EntityFrameworkCore
{
    public class testprojectDbContext : AbpZeroDbContext<Tenant, Role, User, testprojectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public testprojectDbContext(DbContextOptions<testprojectDbContext> options)
            : base(options)
        {
        }
    }
}
