namespace EFWinForms.DesckTop.Context
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
