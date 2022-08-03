using Abp.Application.Services;
using SovTech.MultiTenancy.Dto;

namespace SovTech.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

