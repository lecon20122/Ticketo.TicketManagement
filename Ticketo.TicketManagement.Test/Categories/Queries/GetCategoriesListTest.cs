using AutoMapper;
using Moq;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Ticketo.TicketManagement.Application.Profiles;
using Ticketo.TicketManagement.Test.Mocks;

namespace Ticketo.TicketManagement.Test.Categories.Queries
{

    public class GetCategoriesListTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;

        public GetCategoriesListTest()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();

        }

        [Fact]
        public async Task GetAllCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            Assert.IsType<List<CategoryListVm>>(result);

            Assert.True(result.Count == 5);
        }
    }
}
