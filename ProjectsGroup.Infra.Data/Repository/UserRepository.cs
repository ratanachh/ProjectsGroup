using System.Collections.Generic;
using ProjectsGroup.Domain.Interfaces;
using ProjectsGroup.Domain.Model;
using ProjectsGroup.Infra.Data.Context;

namespace ProjectsGroup.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _ctx;

        public UserRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        
        public IEnumerable<User> GetUsers()
        {
            return _ctx.Users;
        }
    }
}