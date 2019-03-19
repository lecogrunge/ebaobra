namespace EbaObra.Shared.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}