using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SovTech.Configuration.Dto;

namespace SovTech.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SovTechAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
