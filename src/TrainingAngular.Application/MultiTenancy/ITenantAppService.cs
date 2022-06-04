using Abp.Application.Services;
using TrainingAngular.MultiTenancy.Dto;

namespace TrainingAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

