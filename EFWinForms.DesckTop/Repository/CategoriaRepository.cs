using EFWinForms.DesckTop.Context;
using EFWinForms.DesckTop.Interface;
using EFWinForms.DesckTop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFWinForms.DesckTop.Repository
{

    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext _context;

        public CategoriaRepository(DataContext context)
        {
            _context = context;
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }

        public async Task<IEnumerable<Categoria>> ObterTodos()
        {
            var categoria = await _context.Categorias.ToListAsync();
            return categoria;
        }


        public void Salvar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }
    }
}
