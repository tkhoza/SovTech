using System.Threading.Tasks;
using Abp.Application.Services;
using SovTech.Authorization.Accounts.Dto;

namespace SovTech.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
