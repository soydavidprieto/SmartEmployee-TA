using EaApplicationTest.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton(ConfigReader.ReadConfig())
                    .AddScoped<IDriverFixture, DriverFixture>()
                    .AddScoped<IDriverWait, DriverWait>()
                    .AddScoped<ILoginPage, LoginPage>()
                    .AddScoped<IHomePage, HomePage>()
                    .AddScoped<IAfpPage, AfpPage>();
        }
    }
}
