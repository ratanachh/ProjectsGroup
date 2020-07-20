using System.Collections.Generic;
using ProjectsGroup.Domain.Model;

namespace ProjectsGroup.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}