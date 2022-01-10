using Abp.Application.Services;
using testproject.MultiTenancy.Dto;

namespace testproject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

