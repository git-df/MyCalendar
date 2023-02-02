using Application.Mapper;
using Application.Models;
using Application.Services;
using Application.Test.Mocks;
using Application.Validators;
using AutoMapper;
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
    public class SignUpTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUserRepository> _userRepositoryMock;

        public SignUpTest()
        {
            _userRepositoryMock = UserRepositoryMock.GetUserRepository();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Auth_SignUp()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var userSignUp = new UserSignUpModel()
            {
                Email = "test@test.test",
                FirstName = "Test",
                LastName = "Test",
                Password = "Haslo123!",
                ConfirmPassword = "Haslo123!"
            };

            var response = await authService.SignUp(userSignUp);

            response.Success.ShouldBe(true);
            response.Data.ShouldNotBeNull();
            response.Data.ShouldBeOfType<UserInfoModel>();
            response.Message.ShouldBeEmpty();

            var addedUser = await _userRepositoryMock.Object.GetByEmail(userSignUp.Email);
            
            addedUser.ShouldNotBeNull();
            addedUser.Email.ShouldBe(userSignUp.Email.ToLower());
            addedUser.FirstName.ShouldBe(userSignUp.FirstName.ToLower());
            addedUser.LastName.ShouldBe(userSignUp.LastName.ToLower());
        }

        [Fact]
        public async Task Auth_SignUp_UserExist()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var userSignUp = new UserSignUpModel()
            {
                Email = "cjasinski@mc.pl",
                FirstName = "Test",
                LastName = "Test",
                Password = "Haslo123!",
                ConfirmPassword = "Haslo123!"
            };

            var response = await authService.SignUp(userSignUp);

            response.Success.ShouldBe(false);
            response.Data.ShouldBeNull();
            response.Message.ShouldBe("Użytkownik z takim mailem już istnieje");

            var addedUser = await _userRepositoryMock.Object.GetByEmail(userSignUp.Email);

            addedUser.ShouldNotBeNull();
            addedUser.Email.ShouldBe(userSignUp.Email.ToLower());
            addedUser.FirstName.ShouldNotBe(userSignUp.FirstName.ToLower());
            addedUser.LastName.ShouldNotBe(userSignUp.LastName.ToLower());
        }

        [Fact]
        public async Task Auth_SignUp_NoValid()
        {
            var authService = new AuthService(_mapper, _userRepositoryMock.Object, new UserSignInValidator(), new UserSignUpValidator(), new UserPasswordChangeValidator());

            var usersSignUp = new List<UserSignUpModel>()
            {
                new UserSignUpModel()
                {
                    Email = "abc",
                    FirstName = "Test",
                    LastName = "Test",
                    Password = "Haslo123!",
                    ConfirmPassword = "Haslo123!"
                },
                new UserSignUpModel()
                {
                    Email = "",
                    FirstName = "Test",
                    LastName = "Test",
                    Password = "Haslo123!",
                    ConfirmPassword = "Haslo123!"
                },
                new UserSignUpModel()
                {
                    Email = "test@test.test",
                    FirstName = "",
                    LastName = "Test",
                    Password = "Haslo123!",
                    ConfirmPassword = "Haslo123!"
                },
                new UserSignUpModel()
                {
                    Email = "test@test.test",
                    FirstName = "Test",
                    LastName = "",
                    Password = "Haslo123!",
                    ConfirmPassword = "Haslo123!"
                },
                new UserSignUpModel()
                {
                    Email = "test@test.test",
                    FirstName = "Test",
                    LastName = "Test",
                    Password = "Haslo",
                    ConfirmPassword = "Haslo"
                },
                new UserSignUpModel()
                {
                    Email = "test@test.test",
                    FirstName = "Test",
                    LastName = "Test",
                    Password = "",
                    ConfirmPassword = ""
                },
                new UserSignUpModel()
                {
                    Email = "test@test.test",
                    FirstName = "Test",
                    LastName = "Test",
                    Password = "Haslo123!",
                    ConfirmPassword = "123"
                }
            };

            foreach (var user in usersSignUp)
            {
                var response = await authService.SignUp(user);

                response.Success.ShouldBe(false);
                response.Data.ShouldBeNull();
                response.Message.ShouldBeEmpty();

                var addedUser = await _userRepositoryMock.Object.GetByEmail(user.Email);

                addedUser.ShouldBeNull();
            }
        }
    }
}
