using ProjectsGroup.Application.ViewModels;

namespace ProjectsGroup.Application.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUsers();
    }
}