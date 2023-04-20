using EFWinForms.DesckTop.Context;
using EFWinForms.DesckTop.Interface;
using EFWinForms.DesckTop.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWinForms.DesckTop.Formularios
{
    public partial class frmCategoria : Form
    {
        private DataContext _context { get; set; }
        private ICategoriaRepository _categoria;
        private IUnitOfWork _unitOfWork;
        public frmCategoria(DataContext context, ICategoriaRepository categoria, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _context = context;
            _categoria = categoria;
            _unitOfWork = unitOfWork;
        }

        protected async Task CarregaGrid()
        {
            var categoria = await _categoria.ObterTodos();
            List<Categoria> categorias = new List<Categoria>(categoria);
            dataGridView1.DataSource = categorias;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = textBox1.Text;
            _categoria.Salvar(categoria);
            _unitOfWork.Commit();
            CarregaGrid();
        }
    }
}

