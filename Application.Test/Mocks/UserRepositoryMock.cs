using Domain.Entity;
using EmptyFiles;
using Moq;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Test.Mocks
{
    public class UserRepositoryMock
    {
        public static Mock<IUserRepository> GetUserRepository() 
        {
            var users = GetUsers();
            
            var mockUserRepository = new Mock<IUserRepository>();

            mockUserRepository.Setup(repo => repo.GetByGuid(It.IsAny<Guid>())).ReturnsAsync(
                (Guid id) =>
                {
                    return users.FirstOrDefault(u => u.Id == id);
                });

            mockUserRepository.Setup(repo => repo.GetByEmail(It.IsAny<string>())).ReturnsAsync(
                (string email) =>
                {
                    return users.FirstOrDefault(u => u.Email == email);
                });

            mockUserRepository.Setup(repo => repo.Create(It.IsAny<User>())).ReturnsAsync(
                (User user) =>
                {
                    users.Add(user);
                    return user;
                });

            mockUserRepository.Setup(repo => repo.Create(It.IsAny<User>())).ReturnsAsync(
                (User user) =>
                {
                    users.Remove(user);
                    users.Add(user);
                    return user;
                });

            return mockUserRepository;
        }

        private static List<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e"),
                    Email = "hadamski@mc.pl",
                    FirstName = "Henryk",
                    LastName = "Adamski",
                    Password = "631502BC927D8265FAACD1D32299BBCA705BEBF1FD79250E054F77398F5C6B54",
                    Salt = "49DF6A0F9C34A50A9178470E0CE3E1EB841C5F3BEEE2C18B36E77F702CC57A2A",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                    Email = "cjasinski@mc.pl",
                    FirstName = "Cyprian",
                    LastName = "Jasiński",
                    Password = "D22D6E8BCCCD20674DC25D98AA2DAEDCE9BD1D88F7ED6BA16DFFCBB9F0944606",
                    Salt = "B3F4EF86908A730D7243DF0752A1A3A405B1BDDC8B2AE54CEA1F16550F433576",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186"),
                    Email = "nmazur@mc.pl",
                    FirstName = "Nikola",
                    LastName = "Mazur",
                    Password = "EF44C1BAE114AECB845C356DCBC23AA510518214487BE43CECD658F100CF4FA4",
                    Salt = "315419C3F8AB3B7C21A55D9E573DC0F7B40CCF0174CB8874CDC40CF78F7F7E9D",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("0b120695-5261-4a24-89a1-a050944dc4f4"),
                    Email = "akwiatkowska@mc.pl",
                    FirstName = "Agnieszka",
                    LastName = "Kwiatkowska",
                    Password = "C4612FFC6A0C63EF92B85E6B3CC3230265D0CA0C7828589FC59805B0ACF71E73",
                    Salt = "314AE5558CE35ADED929DA1DE17FCE0E16B5F993ECE3EAE552C696F4191E376F",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("e20e44a0-27e3-4a95-9217-a898f54902c3"),
                    Email = "agorski@mc.pl",
                    FirstName = "Antoni",
                    LastName = "Górski",
                    Password = "26D6B907FCB666520B0D76AE5131DCB7DCD94E7ADE749AFB052BA15AEC206B76",
                    Salt = "69258D4399C02EC75555ACF24CC164AAFFEC0CB569977D5F0E11CA69C0BDD7AD",
                    CreatedBy = "SYSTEM",
                }
            };
        }
    }
}
