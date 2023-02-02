using Application.Test.Mocks;
using AutoMapper;
using Moq;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Test.Auth
{
    public class SignInTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUserRepository> _userRepositoryMock;

        public SignInTest()
        {
            _userRepositoryMock = UserRepositoryMock.GetUserRepository();


        }
    }
}
