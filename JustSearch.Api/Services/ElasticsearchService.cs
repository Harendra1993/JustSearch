using JustSearch.Api.Model.ViewModels;
using JustSearch.Api.Models;
using JustSearch.Api.Models.DTOs;
using Nest;
using Newtonsoft.Json;
using System.Text;

namespace JustSearch.Api.Services
{
    public class ElasticSearchService : IElasticSearchService
    {
        protected IElasticClient _client;
        public ElasticSearchService(IElasticClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Index Data to Elasticsearch
        /// </summary>
        /// <param name="client"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool IndexToNestElasticsearch(IList<Items> items)
        {
            var indexResponse = _client.IndexMany<Items>(items, "just-index");

            bool _indexResponse = indexResponse.IsValid;
            if (indexResponse.Errors)
            {
                _indexResponse = indexResponse.IsValid;
            }
            return _indexResponse;
        }

        /// <summary>
        /// Elasticseach search Query
        /// </summary>
        /// <param name="searchDTO"></param>

        public ResultViewModel SearchOnELK(SearchDTO searchDTO)
        {
            ISearchResponse<Items> result = _client.Search<Items>(s => s
                                    .Index("just-index")
                                    .Query(q => q.MatchAll()
                                           )
                                     );

            List<Items> documents = result.Documents.ToList();

            return new ResultViewModel { Hits = documents.ToList(), Count = documents.Count };
        }
    }
}
