using System.Threading.Tasks;
using Abp.Application.Services;
using SovTech.Sessions.Dto;

namespace SovTech.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
