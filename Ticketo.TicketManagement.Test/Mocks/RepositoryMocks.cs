using Moq;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Test.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Concerts" },
                new Category { Id = 2, Name = "Musicals" },
                new Category { Id = 3, Name = "Plays" },
                new Category { Id = 4, Name = "Conferences" },
                new Category { Id = 5, Name = "Comedy" }
            };

            var mockCategoryRepository = new Mock<ICategoryRepository>();

            mockCategoryRepository
                .Setup(repo => repo.ListAllAsync()).ReturnsAsync(categories);

            mockCategoryRepository
                .Setup(repo => repo.AddAsync(It.IsAny<Category>())).ReturnsAsync(
                (Category category) =>
                {
                    categories.Add(category);
                    return category;
                });

            return mockCategoryRepository;

        }
    }
}
