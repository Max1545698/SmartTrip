using SmartTrip.DAL.EF;
using SmartTrip.DAL.Entities;
using SmartTrip.DAL.Interfaces;

namespace SmartTrip.DAL.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        protected ApplicationContext ApplicationContext =>
            Context as ApplicationContext;

        public RoleRepository(ApplicationContext context)
            : base(context) { }
    }
}
