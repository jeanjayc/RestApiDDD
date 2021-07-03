using Autofac;
using RestApiModeloDDD.Infra.CrossCuting.IOC;

namespace RestApiModeloDDD.Infra.CrossCuting
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}