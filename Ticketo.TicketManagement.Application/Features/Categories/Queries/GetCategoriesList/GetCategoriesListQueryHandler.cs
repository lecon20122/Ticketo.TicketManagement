using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Application.Contracts.Persistence;

namespace Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoriesListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryListVm>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var categories = (await _categoryRepository.ListAllAsync()).OrderBy(x => x.Name);

           return _mapper.Map<List<CategoryListVm>>(categories);
        }
    }
}
