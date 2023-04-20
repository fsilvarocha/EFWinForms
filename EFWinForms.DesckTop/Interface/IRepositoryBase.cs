using EFWinForms.DesckTop.Models;

namespace EFWinForms.DesckTop.Interface
{
    public interface IRepositoryBase<T> where T : Entity
    {
        void Salvar(T Obj);

        void Atualizar(T Obj);
    }
}
