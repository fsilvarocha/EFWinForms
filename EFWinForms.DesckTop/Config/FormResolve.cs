using Ninject;
using Ninject.Modules;

namespace EFWinForms.DesckTop.Config
{
    public class FormResolve
    {
        private static IKernel _ninjectKernel;
        public static void Wire(INinjectModule module) => _ninjectKernel = new StandardKernel(module);
        public static T Resolve<T>() => _ninjectKernel.Get<T>();
    }
}
