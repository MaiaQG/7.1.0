using System.Threading.Tasks;
using Abp.Application.Services;
using TrainingAngular.Sessions.Dto;

namespace TrainingAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
