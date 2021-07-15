namespace Examples.OnionArchitecture.Infrastructure.Modules
{
    using Autofac;
    using System;

    public class WebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in Examples.OnionArchitecture.WebApi
            //

            Type startup = Type.GetType("Examples.OnionArchitecture.WebApi.Startup, Examples.OnionArchitecture.WebApi");

            builder.RegisterAssemblyTypes(startup.Assembly)
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}
