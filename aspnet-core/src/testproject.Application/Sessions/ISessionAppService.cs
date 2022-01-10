using System.Threading.Tasks;
using Abp.Application.Services;
using testproject.Sessions.Dto;

namespace testproject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
