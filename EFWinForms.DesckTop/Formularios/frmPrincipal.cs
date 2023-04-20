using EFWinForms.DesckTop.Config;
using EFWinForms.DesckTop.Formularios;
using System.Windows.Forms;

namespace EFWinForms.DesckTop
{

    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmCategoria frmCategoria = FormResolve.Resolve<frmCategoria>();
            frmCategoria.ShowDialog();
        }
    }
}
