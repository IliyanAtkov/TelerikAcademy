using Microsoft.Owin;

[assembly: OwinStartup(typeof(BullsAndCows.Web.Api.Startup))]

namespace BullsAndCows.Web.Api
{
    using System.Reflection;
    using System.Web.Http;

    using Common.Constants;

    using Ninject.Web.Common.OwinHost;
    using Ninject.Web.WebApi.OwinHost;

    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutomapperConfig.RegisterMappings(Assembly.Load(Assemblies.WebApi));

            this.ConfigureAuth(app);

            var httpConfig = new HttpConfiguration();

            WebApiConfig.Register(httpConfig);

            httpConfig.EnsureInitialized();
            app
                .UseNinjectMiddleware(NinjectConfig.CreateKernel)
                .UseNinjectWebApi(httpConfig);
        }
    }
}
