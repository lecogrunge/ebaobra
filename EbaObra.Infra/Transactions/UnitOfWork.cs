using EbaObra.Infra.Persistence.EF;
using EbaObra.Shared.Transactions;

namespace EbaObra.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            this._context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}