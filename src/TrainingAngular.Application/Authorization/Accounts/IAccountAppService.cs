using System.Threading.Tasks;
using Abp.Application.Services;
using TrainingAngular.Authorization.Accounts.Dto;

namespace TrainingAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
