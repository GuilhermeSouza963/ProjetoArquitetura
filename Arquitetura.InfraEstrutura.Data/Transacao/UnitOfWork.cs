using Arquitetura.InfraEstrutura.Data.EntityFramework.Context;

namespace Arquitetura.InfraEstrutura.Data.Transacao
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArquiteturaContext _context;
        public UnitOfWork(ArquiteturaContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            //implementação de log, etc
            _context.SaveChanges();
        }
    }
}
