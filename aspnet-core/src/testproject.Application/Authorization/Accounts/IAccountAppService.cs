using System.Threading.Tasks;
using Abp.Application.Services;
using testproject.Authorization.Accounts.Dto;

namespace testproject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
