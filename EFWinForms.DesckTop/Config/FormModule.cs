using EFWinForms.DesckTop.Context;
using EFWinForms.DesckTop.Interface;
using EFWinForms.DesckTop.Repository;
using Ninject.Modules;

namespace EFWinForms.DesckTop.Config
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DataContext>().To<DataContext>();
            Bind<ICategoriaRepository>().To<CategoriaRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }

        public static FormModule Create() => new FormModule();
    }
}
