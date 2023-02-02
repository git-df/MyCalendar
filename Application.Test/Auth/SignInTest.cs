using Application.Mapper;
using Application.Models;
using Application.Services;
using Application.Services.Interfaces;
using Application.Test.Mocks;
using Application.Validators;
using AutoMapper;
using FluentValidation;
using Moq;
using Persistance.Repositories.Interfaces;
using Shouldly;
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

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Auth_SignIn()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var userSignIn = new UserSignInModel()
            {
                Email = "hadamski@mc.pl",
                Password = "Haslo123!"
            };

            var response = await authService.SignIn(userSignIn);

            response.Success.ShouldBe(true);
            response.Data.ShouldNotBeNull();
            response.Data.ShouldBeOfType<UserInfoModel>();
            response.Message.ShouldBeEmpty();
        }

        [Fact]
        public async Task Auth_SignIn_BadPassword()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var userSignIn = new UserSignInModel()
            {
                Email = "cjasinski@mc.pl",
                Password = "123456789"
            };

            var response = await authService.SignIn(userSignIn);

            response.Success.ShouldBe(false);
            response.Data.ShouldBeNull();
            response.Message.ShouldBe("Błędne hasło");
        }

        [Fact]
        public async Task Auth_SignIn_BadEmail()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var userSignIn = new UserSignInModel()
            {
                Email = "123cjasinski@mc.pl",
                Password = "123456789"
            };

            var response = await authService.SignIn(userSignIn);

            response.Success.ShouldBe(false);
            response.Data.ShouldBeNull();
            response.Message.ShouldBe("Nie znaleziono użytkownika z takim mailem");
        }

        [Fact]
        public async Task Auth_SignIn_NoValid()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var usersSignIn = new List<UserSignInModel> 
            { 
                new UserSignInModel()
                {
                    Email = "",
                    Password = ""
                },
                new UserSignInModel()
                {
                    Email = "abc",
                    Password = ""
                },
                new UserSignInModel()
                {
                    Email = "abc@abc.ab",
                    Password = ""
                },
                new UserSignInModel()
                {
                    Email = "",
                    Password = "abc"
                },
                new UserSignInModel()
                {
                    Email = "",
                    Password = "Haslo123!"
                },
                new UserSignInModel()
                {
                    Email = "abc",
                    Password = "Haslo123!"
                }
            };

            foreach (var user in usersSignIn)
            {
                var response = await authService.SignIn(user);

                response.Success.ShouldBe(false);
                response.Data.ShouldBeNull();
                response.Message.ShouldBeEmpty();
            }
        }
    }
}
