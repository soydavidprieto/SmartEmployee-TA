using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EaSpectFlowTests.Pages;
using EaSpectFlowTests.Pages.SocialSecurity;
using EaFramework.Config;
using EaFramework.Driver;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;

namespace EaSpectFlowTests
{
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            var services = new ServiceCollection();

            services
                .AddSingleton(ConfigReader.ReadConfig())
                .AddScoped<IDriverFixture, DriverFixture>()
                .AddScoped<IDriverWait, DriverWait>()
                .AddScoped<ILoginPage, LoginPage>()
                .AddScoped<IHomePage, HomePage>()
                .AddScoped<IAfpPage, AfpPage>();

            return services;
        }

    }
}