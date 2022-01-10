using System.Threading.Tasks;
using testproject.Configuration.Dto;

namespace testproject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
