using JustSearch.Api.Models;
using JustSearch.Api.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JustSearch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        IElasticSearchService _elasticSearchService;

        public SearchController(IElasticSearchService elasticSearchService)
        {
            _elasticSearchService = elasticSearchService;
        }
        
        // GET: api/<Search>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var value = _elasticSearchService.SearchOnELK(new Models.DTOs.SearchDTO() { });

            return new string[] { "value1", "value2" };
        }

        // GET api/<Search>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Search>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            IList<Items> items = new List<Items>
            {
                new Items() { Description = "Hi this is firt input", Link = "http://okay.okay", Title = "First Input" }
            };

            _elasticSearchService.IndexToNestElasticsearch(items);
        }

        // PUT api/<Search>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Search>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
