using System.Collections.Generic;

namespace JustSearch.Api.Model.ViewModels
{
    public class ResultViewModel
    {
        public Hits Hits { get; set; }
    }

    public class Total
    {
        public int Value { get; set; }
    }

    public class Hits
    {
        public Total total { get; set; }
        public IList<Hit> hits { get; set; }
    }

    public class Hit
    {
        public Items _source { get; set; }
    }
}
