using JustSearch.Api.Model.ViewModels;
using JustSearch.Api.Models;
using JustSearch.Api.Models.DTOs;
using Nest;

namespace JustSearch.Api.Services
{
    public interface IElasticSearchService
    {
        bool IndexToNestElasticsearch(IList<Items> items);
        ResultViewModel SearchOnELK(SearchDTO searchDTO);
    }
}
