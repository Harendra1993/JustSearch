using JustSearch.Api.Models;

namespace JustSearch.Api.Model.ViewModels
{
    public class ResultViewModel
    {
        public int Count { get; set; }
        public IList<Items> Hits { get; set; }
    }

}
