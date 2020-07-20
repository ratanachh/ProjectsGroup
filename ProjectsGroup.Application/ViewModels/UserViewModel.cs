using System.Collections.Generic;
using ProjectsGroup.Domain.Model;

namespace ProjectsGroup.Application.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}