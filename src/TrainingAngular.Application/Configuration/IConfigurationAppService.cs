using System.Threading.Tasks;
using TrainingAngular.Configuration.Dto;

namespace TrainingAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
