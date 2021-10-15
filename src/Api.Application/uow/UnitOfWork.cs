using Api.Application.Interfaces;
using Api.Application.Data.Context;

namespace Api.Application.uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            //
        }
    }
}