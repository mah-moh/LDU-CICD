using Ludu.User.Domain.Repositories;
using Ludu.User.Infrastructure.Data;

namespace Ludu.User.Infrastructure.Repositories
{
    public class CreateUserRepository : Repository<Domain.Entities.User, Guid>, ICreateUserRepository
    {
        public CreateUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
