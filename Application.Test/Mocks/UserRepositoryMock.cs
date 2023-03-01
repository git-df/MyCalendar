using Moq;
using Persistance.Repositories.Interfaces;

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

            mockUserRepository.Setup(repo => repo.Create(It.IsAny<Domain.Entity.User> ())).ReturnsAsync(
                (Domain.Entity.User user) =>
                {
                    users.Add(user);
                    return user;
                });

            mockUserRepository.Setup(repo => repo.Update(It.IsAny<Domain.Entity.User>())).ReturnsAsync(
                (Domain.Entity.User user) =>
                {
                    users.Remove(user);
                    users.Add(user);
                    return user;
                });

            return mockUserRepository;
        }

        public static List<Domain.Entity.User> GetUsers()
        {
            return new List<Domain.Entity.User>()
            {
                new Domain.Entity.User()
                {
                    Id = Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e"),
                    Email = "test1@test.test",
                    FirstName = "test1first",
                    LastName = "test1last",
                    Password = "631502BC927D8265FAACD1D32299BBCA705BEBF1FD79250E054F77398F5C6B54",
                    Salt = "49DF6A0F9C34A50A9178470E0CE3E1EB841C5F3BEEE2C18B36E77F702CC57A2A"
                },
                new Domain.Entity.User()
                {
                    Id = Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                    Email = "test2@test.test",
                    FirstName = "test2first",
                    LastName = "test2last",
                    Password = "D22D6E8BCCCD20674DC25D98AA2DAEDCE9BD1D88F7ED6BA16DFFCBB9F0944606",
                    Salt = "B3F4EF86908A730D7243DF0752A1A3A405B1BDDC8B2AE54CEA1F16550F433576"
                },
                new Domain.Entity.User()
                {
                    Id = Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186"),
                    Email = "test3@test.test",
                    FirstName = "test3first",
                    LastName = "test3last",
                    Password = "EF44C1BAE114AECB845C356DCBC23AA510518214487BE43CECD658F100CF4FA4",
                    Salt = "315419C3F8AB3B7C21A55D9E573DC0F7B40CCF0174CB8874CDC40CF78F7F7E9D"
                }
            };
        }
    }
}
