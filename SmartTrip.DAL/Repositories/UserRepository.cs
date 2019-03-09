using SmartTrip.DAL.EF;
using SmartTrip.DAL.Entities;
using SmartTrip.DAL.Interfaces;

namespace SmartTrip.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public ApplicationContext ApplicationContext =>
            Context as ApplicationContext;

        public UserRepository(ApplicationContext context)
            : base(context)
        {

        }
    }
}
