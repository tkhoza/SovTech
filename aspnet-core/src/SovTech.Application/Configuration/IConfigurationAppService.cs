using System.Threading.Tasks;
using SovTech.Configuration.Dto;

namespace SovTech.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
