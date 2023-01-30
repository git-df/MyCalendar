using Application.Services.Interfaces;
using Domain.Entity;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository= userRepository;
        }

        public async Task<User> Test(User user)
        {
            await _userRepository.Create(user);

            var a = await _userRepository.GetByEmail("dawidflorian99@gmail.com");

            return a;
        }
    }
}
