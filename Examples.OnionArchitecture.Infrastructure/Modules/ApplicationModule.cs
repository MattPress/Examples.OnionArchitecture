namespace Examples.OnionArchitecture.Infrastructure.Modules
{
    using Autofac;
    using Examples.OnionArchitecture.Application;

    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in Examples.OnionArchitecture.Application
            //
            builder.RegisterAssemblyTypes(typeof(ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
