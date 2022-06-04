using System.Threading.Tasks;
using TrainingAngular.Models.TokenAuth;
using TrainingAngular.Web.Controllers;
using Shouldly;
using Xunit;

namespace TrainingAngular.Web.Tests.Controllers
{
    public class HomeController_Tests: TrainingAngularWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}