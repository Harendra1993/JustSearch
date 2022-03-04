using JustSearch.Api.Model.ViewModels;
using JustSearch.Api.Models;
using JustSearch.Api.Models.DTOs;
using Nest;

namespace JustSearch.Api.Services
{
    public class ElasticSearchService : IElasticSearchService
    {
        public bool IndexToNestElasticsearch(IElasticClient client, IList<Items> stackResults)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel SearchOnELK(SearchDTO searchDTO)
        {
            throw new NotImplementedException();
        }
    }
}
