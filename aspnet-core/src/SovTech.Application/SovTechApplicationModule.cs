using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SovTech.Authorization;

namespace SovTech
{
    [DependsOn(
        typeof(SovTechCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SovTechApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SovTechAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SovTechApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
