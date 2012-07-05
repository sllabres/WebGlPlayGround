using StructureMap.Configuration.DSL;
using StructureMap;

namespace Lampkin.Web
{
    public static class StructureMapRegistrar
    {
        public static void Register()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<WebRegistry>();
            });
        }
    }

    public class WebRegistry : Registry
    {
        public WebRegistry()
        {
            
        }
    }
}
