using Application.Test.Mocks.Data;
using Moq;
using Persistance.Repositories.Interfaces;

namespace Application.Test.Mocks
{
    public class UserRepositoryMock
    {
        public static Mock<IUserRepository> GetUserRepository() 
        {
            var users = ContextMock.GetUsers();
            
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
    }
}
