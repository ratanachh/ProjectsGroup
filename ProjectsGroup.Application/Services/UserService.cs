using ProjectsGroup.Application.Interfaces;
using ProjectsGroup.Application.ViewModels;
using ProjectsGroup.Domain.Interfaces;

namespace ProjectsGroup.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public UserViewModel GetUsers()
        {
            return new UserViewModel()
            {
                Users = _userRepository.GetUsers()
            };
        }
    }
}