using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SovTech.EntityFrameworkCore;
using SovTech.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SovTech.Web.Tests
{
    [DependsOn(
        typeof(SovTechWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SovTechWebTestModule : AbpModule
    {
        public SovTechWebTestModule(SovTechEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SovTechWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SovTechWebMvcModule).Assembly);
        }
    }
}