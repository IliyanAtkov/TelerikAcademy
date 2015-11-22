namespace BullsAndCows.Web.Api
{
    using System;
    using System.Web;

    using Common.Constants;

    using Data;
    using Data.Common.Repositories;

    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using Services.Common;

    public static class NinjectConfig
    {
        private static Action<IKernel> dependenciesRegistration = kernel =>
         {
             kernel.Bind<IBullsAndCowsDbContext>().To<BullsAndCowsDbContext>();
             kernel.Bind(typeof(IRepository<>)).To(typeof(EfGenericRepository<>));
         };

        public static Action<IKernel> DependenciesRegistration
        {
            get { return dependenciesRegistration; }
            set { dependenciesRegistration = value; }
        }

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            DependenciesRegistration(kernel);

            kernel.Bind(b => b
                .From(Assemblies.Services)
                .SelectAllClasses()
                .InheritedFrom<IService>()
                .BindDefaultInterface());
        }
    }
}
