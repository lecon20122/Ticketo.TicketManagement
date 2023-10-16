using AutoMapper;
using Moq;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using Ticketo.TicketManagement.Application.Profiles;
using Ticketo.TicketManagement.Test.Mocks;

namespace Ticketo.TicketManagement.Test.Categories.Commands
{
    public class CreateCategoryCommandTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;

        public CreateCategoryCommandTest()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task CreateCategoryTest()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();

            Assert.IsType<CreateCategoryCommandResponse>(result);

            Assert.True(result.Success);

            Assert.True(allCategories.Count == 6);
        }
    }
}
