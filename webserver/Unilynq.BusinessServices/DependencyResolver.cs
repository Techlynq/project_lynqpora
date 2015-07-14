using Unilynq.Resolver;
using System.ComponentModel.Composition;

namespace Unilynq.BusinessServices
{

    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<ILynQerServices, LynQerServices>();
            registerComponent.RegisterType<ITokenServices, TokenServices>();
        }
    }
    
}
