using SmartTrip.DAL.EF;
using SmartTrip.DAL.Core;
using SmartTrip.DAL.Interfaces;
using SmartTrip.DAL.Repositories;

namespace SmartTrip.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Roles = new RoleRepository(_context);
        }

        public IRoleRepository Roles { get; private set; }

        public IUserRepository Users { get; private set; }

        public int Complete() => _context.SaveChanges();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
