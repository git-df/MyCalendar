using Application.Models;
using Application.Responses;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entity;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public AuthService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<ServiceResponse<UserInfoModel>> GetUserInfo(Guid userId)
        {
            var user = await _userRepository.GetByGuid(userId);

            if (user == null)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Nie znaleziono użytkownika o takim id"
                };
            }

            return new ServiceResponse<UserInfoModel>()
            {
                Data = _mapper.Map<UserInfoModel>(user)
            };
        }

        public async Task<ServiceResponse<UserInfoModel>> PasswordChange(Guid userId, UserPasswordChangeModel userPassword)
        {
            if (userPassword.Password != userPassword.ConfirmPassword)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Hasła nie są takie same"
                };
            }

            var user = await _userRepository.GetByGuid(userId);

            if (user == null)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Nie znaleziono użytkownika o takim id"
                };
            }

            user.Salt = SaltGenerator();
            user.Password = HashPassword($"{user.Password}{user.Salt}");

            await _userRepository.Update(user);

            return new ServiceResponse<UserInfoModel>()
            {
                Data = _mapper.Map<UserInfoModel>(user)
            };
        }

        public async Task<ServiceResponse<UserInfoModel>> SignIn(UserSignInModel user)
        {
            var userFromBase = await _userRepository.GetByEmail(user.Email.ToLower());

            if (userFromBase == null)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Nie znaleziono użytkownika z takim mailem"
                };
            }

            if (userFromBase.Password != HashPassword($"{user.Password}{userFromBase.Salt}"))
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Błędne hasło"
                };
            }

            return new ServiceResponse<UserInfoModel>()
            {
                Data = _mapper.Map<UserInfoModel>(userFromBase)
            };
        }

        public async Task<ServiceResponse<UserInfoModel>> SignUp(UserSignUpModel user)
        {
            if (user.Password != user.ConfirmPassword)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Hasła nie są takie same"
                };
            }

            var userFromBase = await _userRepository.GetByEmail(user.Email.ToLower());

            if (userFromBase != null)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Użytkownik z takim mailem już istnieje"
                };
            }

            var newUser = _mapper.Map<User>(user);
            newUser.FirstName = newUser.FirstName.ToLower();
            newUser.LastName = newUser.LastName.ToLower();
            newUser.Email = newUser.Email.ToLower();
            newUser.Salt = SaltGenerator();
            newUser.Password = HashPassword($"{user.Password}{newUser.Salt}");

            await _userRepository.Create(newUser);

            return new ServiceResponse<UserInfoModel>()
            {
                Data = _mapper.Map<UserInfoModel>(newUser)
            };
        }

        public async Task<ServiceResponse<UserInfoModel>> UserDataChange(Guid userId, UserDataChangeModel dataChangeModel)
        {
            var user = await _userRepository.GetByGuid(userId);

            if (user == null)
            {
                return new ServiceResponse<UserInfoModel>()
                {
                    Success = false,
                    Message = "Nie znaleziono użytkownika o takim id"
                };
            }

            user.FirstName = dataChangeModel.FirstName.ToLower();
            user.LastName = dataChangeModel.LastName.ToLower();
            
            await _userRepository.Update(user);

            return new ServiceResponse<UserInfoModel>()
            {
                Data = _mapper.Map<UserInfoModel>(user)
            };
        }

        string HashPassword(string passwordWithSalt)
        {
            SHA256 sHA256 = SHA256.Create();
            var passwordBytes = Encoding.Default.GetBytes(passwordWithSalt);
            var passwordHash = sHA256.ComputeHash(passwordBytes);
            return Convert.ToHexString(passwordHash);
        }

        string SaltGenerator()
        {
            var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[32];
            rng.GetNonZeroBytes(salt);
            return Convert.ToHexString(salt);
        }
    }
}
