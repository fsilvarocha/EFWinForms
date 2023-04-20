using EFWinForms.DesckTop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFWinForms.DesckTop.Interface
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        Task<IEnumerable<Categoria>> ObterTodos();
    }
}
