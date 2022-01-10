using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using testproject.Configuration.Dto;

namespace testproject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : testprojectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
