using System;

using SmartTrip.DAL.Interfaces;

namespace SmartTrip.DAL.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}
