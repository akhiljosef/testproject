using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using testproject.EntityFrameworkCore;
using testproject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace testproject.Web.Tests
{
    [DependsOn(
        typeof(testprojectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class testprojectWebTestModule : AbpModule
    {
        public testprojectWebTestModule(testprojectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(testprojectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(testprojectWebMvcModule).Assembly);
        }
    }
}