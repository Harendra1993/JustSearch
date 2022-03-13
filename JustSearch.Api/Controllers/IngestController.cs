using JustSearch.Api.Data;
using JustSearch.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JustSearch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngestController : ControllerBase
    {
        IElasticSearchService _elasticSearchService;

        public IngestController(IElasticSearchService elasticSearchService)
        {
            _elasticSearchService = elasticSearchService;
        }

        // POST api/<Ingest>
        [HttpPost]
        public void Post()
        {
            ItemsData itemsData = new ItemsData();

            _elasticSearchService.IndexToNestElasticsearch(itemsData.items);
        }
    }
}
