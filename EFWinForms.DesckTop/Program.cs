using EFWinForms.DesckTop.Config;
using System;
using System.Windows.Forms;

namespace EFWinForms.DesckTop
{

    static class Program
    {


        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormResolve.Wire(FormModule.Create());
            Application.Run(FormResolve.Resolve<frmPrincipal>());
        }
    }
}
