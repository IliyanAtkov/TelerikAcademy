namespace BullsAndCows.Web.Api.Tests
{
    using System.Reflection;

    using Common.Constants;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestInit
    {
        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
           // NinjectConfig.DependenciesRegistration = kernel =>
           // {
           //     kernel.Bind<IRepository<User>>().ToConstant(Repositories.GetUsersRepository());
           // };
            AutomapperConfig.RegisterMappings(Assembly.Load(Assemblies.WebApi));
        }
    }
}
